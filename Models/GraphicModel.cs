﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Models
{
    public class GraphicModel
    {
        public string StationName { get; set; }
        public BikeNamesAndCount series { get; set; }
    }
}
