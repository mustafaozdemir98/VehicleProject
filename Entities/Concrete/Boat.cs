﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Boat:Vehicle
    {
        public int Id { get; set; }
        public string BoatName { get; set; }
        public string Color { get; set; }
    }
}
