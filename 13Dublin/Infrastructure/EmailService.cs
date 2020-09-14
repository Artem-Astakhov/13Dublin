using _13Dublins.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Infrastructure
{
    public class EmailService
    {
        private ILogger logger;
       public EmailService(ILogger<EmailService> logger)
        {
            this.logger = logger;
        }

        public void SendEmail(Order order)
        {
            string messagePath = order.Email;
            int orderNumber = order.Id;                                
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Артем Астахов", "crazydoomchik@gmail.com"));
                message.To.Add(new MailboxAddress("", messagePath));
                message.Subject = "Бронь билетов 13Dublins";
                message.Body = new BodyBuilder() {HtmlBody = $"<div>Здравствуйте. Билеты забронированы. Номер брони {orderNumber}." }.ToMessageBody();

                using(SmtpClient client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("crazydoomchik@gmail.com", "crazy12345AA");
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch(Exception exe)
            {
                logger.LogError(exe.GetBaseException().Message);
            }
        }
    }
}
