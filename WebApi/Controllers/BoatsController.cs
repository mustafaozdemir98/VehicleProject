using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : Controller
    {
        private readonly IBoatService _boatService;
        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet]
        public async Task<IEnumerable<Boat>> GetBoats()
        {
            return await _boatService.Get();
        }

        [Route("getbycolor/{color}")]
        [HttpGet]
        public async Task<List<Boat>> GetCarByColor(string color)
        {
            return await _boatService.GetByBoatColor(color);
        }
    }
}
