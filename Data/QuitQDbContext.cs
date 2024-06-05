using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewQuitQ.Models;

namespace NewQuitQ.Data
{
    public class QuitQDbContext : DbContext
    {
        public QuitQDbContext (DbContextOptions<QuitQDbContext> options)
            : base(options)
        {
        }

        public DbSet<NewQuitQ.Models.User> User { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Products> Products { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Categories> Categories { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Cart> Cart { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Orders> Orders { get; set; } = default!;
        public DbSet<NewQuitQ.Models.OrderItems> OrderItems { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Payments> Payments { get; set; } = default!;
        public DbSet<NewQuitQ.Models.Review> Review { get; set; } = default!;
    }
}
