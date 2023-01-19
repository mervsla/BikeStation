using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Models
{
    public class BikeModel
    {
        public string bike_id { get; set; }
        public string station_id { get; set; }
        public string name { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public int is_reserved { get; set; }
        public int is_disabled { get; set; }


    }
}
