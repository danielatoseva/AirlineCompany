using AirlineCompany.DAL;
using AirlineCompany.Models.Airplanes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.BLL.admin
{
    public class DestinationBlo
    {
        private CommonDao<Destination> dao = new CommonDao<Destination>();

        public void Create(string Name, int CountryId)
        {
            CommonDao<Country> countryDao = new CommonDao<Country>();
            Destination destination = new Destination()
            {
                Name = Name,
                CountryId = CountryId
            };

            dao.Create(destination);
        }

        public void Delete(int ID)
        {
            dao.DeleteByID(ID);
        }

        public void Edit(int ID, string Name, Country Country, ICollection<Flight> Flights)
        {
            Destination destination = new Destination()
            {
                ID = ID,
                Name = Name,
                Country = Country,
                Flights = Flights

            };

            dao.Update(destination);

        }

        public List<Destination> GetAll()
        {
            return dao.GetDbSet().Include(e => e.Country).ToList();
        }
    }
}
