using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.Models
{
    public class CommonGeneric<TIdentity>
    {
        public TIdentity ID { get; set; }
    }
}
