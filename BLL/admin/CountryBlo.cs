using AirlineCompany.DAL;
using AirlineCompany.Models.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace AirlineCompany.BLL.admin
{
    public class CountryBlo
    {
        private CommonDao<Country> dao = new CommonDao<Country>();
        public void Create(string Name)
        {
            Country country = new Country()
            {
                Name = Name
            };

            dao.Create(country);
        }

        public void Delete(int ID)
        {
            dao.DeleteByID(ID);
        }

        public void Edit(int ID, string Name)
        {
            Country country = new Country()
            {
                ID = ID,
                Name = Name

            };

            dao.Update(country);
        }
    }
}
