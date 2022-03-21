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
    public class HotelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }
        [HttpPost]
        public async Task<Hotel> AddCustAsync(Hotel hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }
    }
}
