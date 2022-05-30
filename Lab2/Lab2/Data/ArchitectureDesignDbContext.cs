using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Data
{
    public class ArchitectureDesignDbContext : DbContext
    {
        public ArchitectureDesignDbContext(DbContextOptions<ArchitectureDesignDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<FinalOrder> FinalOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
