using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public class ShipmentModel : Entity
    {


        public LocationModel To { get; set; }

        public LocationModel From { get; set; }

        public ICollection<ShipmentTypeModel> ForsendelseTypes { get; set; }

        public double Price { get; set; }

        public long NavId { get; set; }

        public ICollection<RouteModel> Routes { get; set; }


    }
}
