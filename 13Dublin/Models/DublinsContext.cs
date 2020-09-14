using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public class DublinsContext:DbContext
    {
        public DublinsContext (DbContextOptions<DublinsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoCategory> VideoCategories { get; set; }
        public  DbSet<Ticket> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
