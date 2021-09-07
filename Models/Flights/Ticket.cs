using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models.Flights
{
    public class Ticket : Common
    {
        public int Number { get; set; }

        public int Price { get; set; }
    }
}
