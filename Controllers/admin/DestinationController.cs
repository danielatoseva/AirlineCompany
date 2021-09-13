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
    public class DestinationController : Controller
    {
        
        public IActionResult Index()
        {
            DestinationBlo blo = new DestinationBlo();
            return View(blo.GetAll());
        }

        public IActionResult Insert(string Name, int CountryId)
        {
            AirlineCompanyContext context = new AirlineCompanyContext();

            if (Name == null)
            {
                CommonDao<Country> dao = new CommonDao<Country>();
                return View(dao.GetAll());
            }
            // Insert destination
            DestinationBlo blo = new DestinationBlo();
            blo.Create(Name, CountryId);
            // return index
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int ID, string Name, Country Country, ICollection<Flight> Flights)
        {
            if (Name == null)
            {
                Destination Destination = new Destination()
                {
                    ID = ID,
                    Name = Name,
                    Country = Country,
                    Flights = Flights
                };
                return View(Destination);
            }
            else
            {
                DestinationBlo blo = new DestinationBlo();
                blo.Edit(ID, Name, Country, Flights);
            }

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            DestinationBlo blo = new DestinationBlo();
            blo.Delete(id);

            return RedirectToAction("Index");

        }
    }
}