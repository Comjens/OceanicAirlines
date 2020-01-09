using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public class Rute : Entity
    {
        public Lokation from { get; set; }

        public Lokation to { get; set; }

        public  double duration { get; set; }

        public double price1 { get; set; }

        public double price2 { get; set; }

        public double price3 { get; set; }
    }
}
