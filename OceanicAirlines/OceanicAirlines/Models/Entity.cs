using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OceanicAirlines.Model
{
    public abstract class Entity
    {
        public long Id { get; set; }

        public String Name { get; set; }

        public DateTime CreatededTime { get; set; }

        public DateTime UpdatedTime { get; set; }
    }
}
