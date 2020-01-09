using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public class Forsendelse : Entity
    {


        public Lokation to { get; set; }

        public Lokation from { get; set; }

        public ForsendelseType[] forsendelseTypes { get; set; }

        public double price { get; set; }

        public long NAVID { get; set; }

        public Rute[] rutes { get; set; }


    }
}
