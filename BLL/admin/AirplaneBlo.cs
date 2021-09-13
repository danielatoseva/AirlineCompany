using AirlineCompany.DAL;
using AirlineCompany.Models.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineCompany.BLL.admin
{
    public class AirplaneBlo
    {
        private CommonDao<Airplane> dao = new CommonDao<Airplane>();

        public void Create(AirplaneModel MyProperty)
        {
            Airplane airplane = new Airplane()
            {
                MyProperty = MyProperty
            };
            dao.Create(airplane);
        }

        public void Delete(int ID)
        {
            dao.DeleteByID(ID);
        }

        public void Edit(int ID, AirplaneModel MyProperty)
        {
            Airplane airplane = new Airplane()
            {
                ID = ID,
                MyProperty = MyProperty

            };

            dao.Update(airplane);
        }
    }
}
