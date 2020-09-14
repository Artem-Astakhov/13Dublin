using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class CreateOrder
    {
        DublinsContext context;
        private Cart cart;

        public CreateOrder(DublinsContext rep, Cart cart)
        {
            context = rep;
            this.cart = cart;
        }
        public void Create(Order order)
        {
            order.OrderTime = DateTime.Now;
            context.Orders.Add(order);
            context.SaveChanges();
            
            var items = cart.Lines;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    Name = el.Ticket.Name, 
                    Row = el.Ticket.Row, 
                    Place = el.Ticket.Place, 
                    Price=el.Ticket.Price, 
                    OrderId = order.Id,
                    TicketId=el.Ticket.Id 
                    
                };
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
        }
    }
}
