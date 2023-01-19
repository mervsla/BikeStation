using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BikeStation.Constants.Constants;

namespace BikeStation.Models
{
    public class StationModel
    {
        public string region_id { get; set; }
        public string station_id { get; set; }
        public string name { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string address { get; set; }
        public List<string> rental_methods { get; set; }
    }
}
