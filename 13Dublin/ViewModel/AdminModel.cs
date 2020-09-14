using _13Dublins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.ViewModel
{
    public class AdminModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        DublinsContext context;

        public AdminModel()
        {

        }
        public AdminModel(DublinsContext context)
        {
            this.context = context;
            
        }

        

    }
}
