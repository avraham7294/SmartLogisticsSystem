using Microsoft.EntityFrameworkCore;
using SmartLogisticsSystem.Models;

namespace SmartLogisticsSystem.Data
{
    public class SmartLogisticsDbContext : DbContext
    {
        public SmartLogisticsDbContext(DbContextOptions<SmartLogisticsDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
    }
}
