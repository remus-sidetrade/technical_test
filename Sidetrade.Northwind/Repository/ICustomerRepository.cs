using Sidetrade.Northwind.Model_Entities;

namespace Sidetrade.Northwind.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById(string id);
        Task<IList<Customer>> GetAllCustomerAsync();

    }
}
