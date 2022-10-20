using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BusService:IBusService
    {
        private readonly DatabaseContext _context;

        public BusService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Bus>> Get()
        {
            return await _context.Buses.ToListAsync();
        }

        public async Task<List<Bus>> GetByBusColor(string Color)
        {
            return await _context.Buses.Where(v => v.Color == Color).ToListAsync();

        }
    }
}
