using _13Dublins.Models;
using _13Dublins.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Controllers
{
    public class MainPageController:Controller
    {
        private IDublinsRepository repository;
        public MainPageController(IDublinsRepository rep)
        {
            repository = rep;
        }
        public IActionResult Main()
        {
            MainPageModel obj = new MainPageModel(repository);
            return View(obj);
        }
    }
}
