using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.Models.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace AirlineCompany.Controllers.admin
{
    public class DestinationController : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            AirlineCompanyContext context = new AirlineCompanyContext();
            return View(context.Destination);
        }

        public IActionResult Insert(string Name)
        {
            AirlineCompanyContext context = new AirlineCompanyContext();
            return View(context.Country);
        }
    }
}