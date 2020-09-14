using _13Dublins.Infrastructure;
using _13Dublins.Models;
using _13Dublins.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Controllers
{
    public class CartController:Controller
    {
        IDublinsRepository repository;
        private Cart cart;
        DublinsContext context;

        public CartController(IDublinsRepository rep, Cart cartService, DublinsContext context)
        {
            repository = rep;
            cart = cartService;
            this.context = context;
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var ticket = repository.Tickets.Where(i => i.Id == id).FirstOrDefault();

            if (ticket != null)
            {
                cart.AddTicket(ticket, 1);
            }
            ticket.Available = false;
            context.Update(ticket);
            context.SaveChanges();

            return RedirectToAction("Index", "Ticket");
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            var ticket = repository.Tickets.Where(i => i.Id == id).FirstOrDefault();
            if (ticket != null)
            {
                cart.RemoveLine(ticket);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var obj = new CartViewModel();
            obj.Cart = cart;
            return View(obj);
        }
    }
}
