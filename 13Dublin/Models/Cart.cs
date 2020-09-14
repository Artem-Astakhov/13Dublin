using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddTicket(Ticket ticket, int quantity)
        {
            
            CartLine line = lineCollection.Where(t => t.Ticket.Id == ticket.Id).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(
                    new CartLine 
                    { 
                        Ticket = ticket, 
                        Quantity = quantity 
                    });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Ticket ticket)
        {
            lineCollection.RemoveAll(i => i.Ticket.Id == ticket.Id);
        }

        public int TotalValue()
        {
            return lineCollection.Sum(e => e.Ticket.Price * e.Quantity);
        }

        public virtual void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public int Quantity { get; set; }
    }
}
