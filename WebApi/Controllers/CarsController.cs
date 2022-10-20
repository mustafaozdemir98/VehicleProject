using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _carService.GetAll();
        }

        [Route("getbyid/{id}")]
        [HttpGet]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            return await _carService.GetById(id);
        }

        [Route("getbycolor/{color}")]
        [HttpGet]
        public async Task<List<Car>> GetCarByColor(string color)
        {
            return await _carService.GetByCarColor(color);
        }

        
        [Route("createcar")]
        [HttpPost]
        public async Task<ActionResult<Car>> CreateCar([FromBody] Car car)
        {
            var newVehicle = await _carService.Create(car);
            return CreatedAtAction(nameof(GetCars), new { id = newVehicle.Id }, newVehicle);
        }
        [HttpPost("updatecar/{id}")]
        public async Task<ActionResult> UpdateCar(int id, [FromBody] Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            await _carService.Update(car);
            return Ok(car);
        }

        [HttpPut("onoffheadlights/{id}")]
        public IActionResult HeadLightsOnOff(int id)
        {
             _carService.HeadLightsOnOff(id);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteCar(int id)
        {
            var vehicleToDelete = await _carService.GetById(id);
            if (vehicleToDelete == null)
            {
                return NotFound();
            }
            await _carService.Delete(vehicleToDelete.Id);
            return Ok(vehicleToDelete);
        }
    }
}
