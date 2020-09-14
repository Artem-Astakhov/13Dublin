using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public interface IDublinsRepository
    {
        IQueryable<Video> Videos { get; }
        IQueryable<VideoCategory> VideoCategories { get; }
        IQueryable<Ticket> Tickets { get; }
        IQueryable<Order> Orders { get; }
        IQueryable<OrderDetail> OrderDetails { get; }
    }
}
