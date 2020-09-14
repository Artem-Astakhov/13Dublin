using _13Dublins.Models;
using _13Dublins.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Controllers
{
    public class AdminController:Controller
    {
        IDublinsRepository repository;
        DublinsContext context;
        IWebHostEnvironment hostEnvironment;

        public AdminController(DublinsContext context, IWebHostEnvironment hostEnvironment, IDublinsRepository rep)
        {
            this.context = context;
            this.hostEnvironment = hostEnvironment;
            this.repository = rep;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                var admin = context.Admins.FirstOrDefault(a => a.Name == model.Name && a.Password == model.Password);
                if (admin != null)
                {
                    return RedirectToAction("Adminka");
                }
                else ModelState.AddModelError("", "Не корректные данные");
            }
            return View(model);
        }

        public IActionResult Adminka()
        {
            return View();
        }

        public IActionResult TicketView()
        {
            TicketViewModel obj = new TicketViewModel(repository);
            return View(obj);
        }

        public IActionResult AddNewTicket()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                for(int i = 0; i < ticket.Row; i++)
                {
                    for(int j = 0; j<ticket.Place; j++)
                    {
                        context.Tickets.Add(
                            new Ticket
                            {
                                Name = ticket.Name,
                                Company = ticket.Company,
                                Row = i + 1,
                                Place = j + 1,
                                Available = true,
                                Date = ticket.Date,
                                Price = ticket.Price

                            });
                        context.SaveChanges();
                    }
                }
            }
            return RedirectToAction("TicketView");
        }

        public IActionResult DeleteTicket()
        {
            context.Tickets.RemoveRange(context.Tickets);
            context.SaveChanges();
            return RedirectToAction("TicketView");
        }


        



    }
}
