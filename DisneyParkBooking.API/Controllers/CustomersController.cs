using DisneyParkBooking.Data;
using DisneyParkBooking.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyParkBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();

        }
        [HttpPost]
        public async Task<Customer> AddCustAsync(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}

