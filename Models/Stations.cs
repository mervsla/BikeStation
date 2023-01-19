using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Models
{
    public class Stations
    {
        public Stations()
        {
            data = new StationData();
        }
        public long last_updated { get; set; }
        public int ttl { get; set; }
        public StationData data { get; set; }
    }
}
