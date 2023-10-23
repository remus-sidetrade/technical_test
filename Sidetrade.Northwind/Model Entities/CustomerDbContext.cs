using Microsoft.EntityFrameworkCore;

namespace Sidetrade.Northwind.Model_Entities
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
