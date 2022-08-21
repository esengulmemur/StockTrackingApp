using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityFrameworkCore.EntityFrameworkCore
{
    public class DBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BIM-ESENGUL\\LOCALHOST;database=StockTrackingDB;trusted_connection=true;");
        }
    }
}
