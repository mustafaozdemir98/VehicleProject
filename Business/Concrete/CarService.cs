using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework.Repositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarService:ICarService
    {
        private readonly DatabaseContext _context;
        

        public CarService(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _context.Cars.ToListAsync();
        }
        
        public async Task<Car> GetById(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        
        public async Task<List<Car>> GetByCarColor(string Color)
        {
            return await _context.Cars.Where(v => v.Color == Color).ToListAsync();

        }
        


        public bool HeadLightsOnOff(int id)
        {
            var car = _context.Cars.Where(x=>x.Id==id).First();
            if (car.Headlights == true)
                car.Headlights = false;
            else
                car.Headlights = true;
            _context.Update(car);
            _context.SaveChanges();
            return true;
        }
        public async Task Delete(int id)
        {
            var vehicleToDelete = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(vehicleToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Car> Create(Car car)
        {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return car;

        }

        public async Task Update(Car car)
        {
                _context.Entry(car).State = EntityState.Modified;
                await _context.SaveChangesAsync();
        }
        
    }
}
