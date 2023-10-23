using Microsoft.AspNetCore.Mvc;
using Sidetrade.Northwind.Model_Entities;
using Sidetrade.Northwind.Repository;

namespace Sidetrade.Northwind.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase 
    {
        private readonly ICustomerRepository _cutomer;

        public CustomerController(ICustomerRepository customer)
        {
            _cutomer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        [HttpGet]
        [Route("customers/{id}")]
        public async Task<IActionResult> GetCustomerByIdAsync(string id)
        {
            return Ok(await _cutomer.GetCustomerById(id));
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            return Ok(await _cutomer.GetAllCustomerAsync());
        }
    }
}
