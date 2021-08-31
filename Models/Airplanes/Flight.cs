using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models.Airplanes
{
    public class Flight : Common
    {
        public Airplane FlownBy { get; set; }
        public ICollection<Destination> Destination { get; set; }
    }
}
