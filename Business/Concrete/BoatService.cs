using Business.Abstract;
using DataAccess.Abstract;
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
    public class BoatService:IBoatService
    {
        private readonly DatabaseContext _context;

        public BoatService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Boat>> Get()
        {
            return await _context.Boats.ToListAsync();
        }

        public async Task<List<Boat>> GetByBoatColor(string Color)
        {
            return await _context.Boats.Where(v => v.Color == Color).ToListAsync();

        }
    }
}
