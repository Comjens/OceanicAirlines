using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public class RouteModel : Entity
    {
        public LocationModel From { get; set; }

        public LocationModel To { get; set; }

        public  double Duration { get; set; }

        public double Price1 { get; set; }

        public double Price2 { get; set; }

        public double Price3 { get; set; }
    }
}
