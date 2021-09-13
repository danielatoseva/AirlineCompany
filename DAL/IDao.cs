using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineCompany.DAL
{
    interface IDao<TEntity> where TEntity : Common
    {
        DbSet<TEntity> GetDbSet();
        void Create(TEntity Entity);
        void Update(TEntity Entity);
        void Delete(TEntity Entity);
        void DeleteByID(int ID);
        TEntity GetById(int ID);
        IEnumerable<TEntity> GetAll();
    }
}
