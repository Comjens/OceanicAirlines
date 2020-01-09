using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public class Shipment : Entity
    {


        public Location To { get; set; }

        public Location From { get; set; }

        public ShipmentType[] ForsendelseTypes { get; set; }

        public double Price { get; set; }

        public long NavId { get; set; }

        public Route[] Routes { get; set; }


    }
}
