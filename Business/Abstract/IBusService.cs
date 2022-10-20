using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBusService
    {
        Task<IEnumerable<Bus>> Get();
        Task<List<Bus>> GetByBusColor(string buseColor);
    }
}
