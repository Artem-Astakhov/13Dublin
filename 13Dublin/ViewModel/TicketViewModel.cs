using _13Dublins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.ViewModel
{
    public class TicketViewModel
    {
        IDublinsRepository repository;
        public TicketViewModel(IDublinsRepository rep)
        {
            repository = rep;
        }

        public List<Ticket> Tickets => repository.Tickets.OrderBy(p => p.Row).ToList();
        public int RowCount => repository.Tickets.GroupBy(p => p.Row).Select(g => g.Count()).Count();
    }
}
