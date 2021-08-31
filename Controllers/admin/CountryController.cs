using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.BLL.admin;
using AirlineCompany.DAL;
using AirlineCompany.Models.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace AirlineCompany.Controllers.admin
{
    [Route("[controller]/[action]")]
    public class CountryController : Controller
    { 
        public IActionResult Index()
        {
            CommonDao<Country> context = new CommonDao<Country>();
            return View(context.GetAll());
        }

        public IActionResult Insert(string Name)
        {
            if (Name == null)
            {
                return View();
            }
            // Insert country
            CountryBlo blo = new CountryBlo();
            blo.Create(Name);
            // return index
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id, string name)
        {
            if (name == null)
            {
                Country country = new Country()
                {
                    ID = id,
                    Name = name
                };
                return View(country);
            }
            else
            {
                CountryBlo blo = new CountryBlo();
                blo.Edit(id, name);
            }

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            CountryBlo blo = new CountryBlo();
            blo.Delete(id);

            return RedirectToAction("Index");
                
        }
    }
}