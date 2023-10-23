using Microsoft.EntityFrameworkCore;
using Sidetrade.Northwind.Model_Entities;

namespace Sidetrade.Northwind.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly CustomerDbContext _context;
        public CustomerRepository(CustomerDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Customer> GetCustomerById(string id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IList<Customer>> GetAllCustomerAsync()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }
    }
}
