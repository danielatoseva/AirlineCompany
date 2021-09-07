using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models.Flights
{
    public class AirRoute : Common
    {
        public string Name { get; set; }
        public uint Distance { get; set; }
        public uint Altitude { get; set; }
    }
}
