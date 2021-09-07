using AirlineCompany.Models.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models.Airplanes
{
    public class FlightDestinations : Common
    {
        public Destination Destination { get; set; }
        public Flight Flight { get; set; }
        public AirRoute AirRoute { get; set; }
    }
}
