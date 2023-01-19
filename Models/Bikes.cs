using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Models
{
    public class Bikes
    {
        public Bikes()
        {
             data=new BikeData();
        }
        public long last_updated { get; set; }
        public int ttl { get; set; }
        public BikeData data { get; set; }
    }
}
