using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Vehicle
    {
        public int Id { get; set; }
        public string Wheels { get; set; }
        public string Color { get; set; }
        public string CarName { get; set; }
        public bool Headlights { get; set; }

    }
}
