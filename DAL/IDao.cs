using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.Models;

namespace AirlineCompany.DAL
{
    interface IDao<TEntity> where TEntity : Common
    {
        void Create(TEntity Entity);
        void Update(TEntity Entity);
        void Delete(TEntity Entity);
        void DeleteByID(int ID);
        TEntity GetById(int ID);
        IEnumerable<TEntity> GetAll();
    }
}
