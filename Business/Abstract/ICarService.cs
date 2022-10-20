using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAll();
        Task<Car> GetById(int id);
        Task<List<Car>> GetByCarColor(string Color);
        bool HeadLightsOnOff(int id);
        Task Delete(int id);

        Task<Car> Create(Car car);
        Task Update(Car car);
    }
}
