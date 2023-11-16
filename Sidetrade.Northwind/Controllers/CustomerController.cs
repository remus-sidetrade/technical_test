using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Sidetrade.Northwind.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase 
    {
        private readonly CustomerDbContext _context;

        public CustomerController(CustomerDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        [Route("customers/{id}")]
        public async Task<IActionResult> GetCustomerByIdAsync(string id)
        {
            return Ok(await _context.Customers.FirstOrDefaultAsync(x => x.CustomerID == id));
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            return Ok(await _context.Customers.ToListAsync());
        }
    }

    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
