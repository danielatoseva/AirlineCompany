using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AirlineCompany.Controllers.admin
{
    [Route("[controller]/[action]")]
    public class AirplaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}