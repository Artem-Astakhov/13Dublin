using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Place { get; set; }
        public int Row { get; set; }
        public int OrderId { get; set; }
        public int TicketId { get; set; }



        public Ticket Ticket { get; set; }
        public Order Order { get; set; }
    }
}
