using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class EFDublinsRepository : IDublinsRepository
    {
        private DublinsContext context;
        public EFDublinsRepository(DublinsContext context)
        {
            this.context = context;
        }
        public IQueryable<Video> Videos => context.Videos;

        public IQueryable<VideoCategory> VideoCategories => context.VideoCategories;
        public IQueryable<Ticket> Tickets => context.Tickets;
        public IQueryable<Order> Orders => context.Orders;
        public IQueryable<OrderDetail> OrderDetails => context.OrderDetails;
    }
}
