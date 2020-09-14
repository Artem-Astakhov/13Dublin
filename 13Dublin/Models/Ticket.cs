using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Количество рядов")]
        public int Row { get; set; }

        [Display(Name = "Количество мест")]
        public int Place { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
