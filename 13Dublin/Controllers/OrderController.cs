using _13Dublins.Infrastructure;
using _13Dublins.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Controllers
{
    public class OrderController : Controller
    {
        DublinsContext repository;
        private Cart cart;
        ILogger<EmailService> logger;
        public OrderController(DublinsContext rep, Cart cartService, ILogger<EmailService> logger)
        {
            repository = rep;
            cart = cartService;
            this.logger = logger;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var createOrder = new CreateOrder(repository, cart);
            if (cart.Lines == null)
            {
                ModelState.AddModelError("", "Товары не добавлены");
            }

            if (ModelState.IsValid)
            {
                createOrder.Create(order);
                var email = new EmailService(logger);
                email.SendEmail(order);
                cart.Clear();
                
                return RedirectToAction("Complite", order);
            }
            return View(order);
        }

        public IActionResult Complite(Order order)
        {
            ViewBag.Message = "Заказ успешно создан";
            return View(order);
        }
    }
}
