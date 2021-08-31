﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models.Airplanes
{
    public class Destination : Common
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
