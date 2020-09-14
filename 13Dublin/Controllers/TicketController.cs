using _13Dublins.Models;
using _13Dublins.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Controllers
{
    public class TicketController:Controller
    {
        private IDublinsRepository repository;
        public TicketController (IDublinsRepository rep)
        {
            repository = rep;
        }

        public IActionResult Index()
        {
            var obj = new TicketViewModel(repository);
            return View(obj);
        }
    }
}
