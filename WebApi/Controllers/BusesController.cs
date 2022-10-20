using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : Controller
    {
        private readonly IBusService _busService;
        public BusesController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        public async Task<IEnumerable<Bus>> GetBuses()
        {
            return await _busService.Get();
        }

        [Route("getbycolor/{color}")]
        [HttpGet]
        public async Task<List<Bus>> GetCarByColor(string color)
        {
            return await _busService.GetByBusColor(color);
        }
    }
}
