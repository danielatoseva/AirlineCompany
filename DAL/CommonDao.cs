using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineCompany.Models;
using Microsoft.EntityFrameworkCore;
using AirlineCompany;
using AirlineCompany.Models.Airplanes;

namespace AirlineCompany.DAL
{
    public class CommonDao<TEntity> : IDao<TEntity>
        where TEntity : Common
    {
        private DbContext _context;

        public CommonDao(DbContext Context)
        {
            _context = Context;
        }

        public CommonDao() : this(new AirlineCompanyContext())
        {

        }

        public void Create(TEntity Entity)
        {
            try
            {
                _context.Set<TEntity>().Add(Entity);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TEntity Entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(Entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteByID(int ID)
        {
            try
            {
                TEntity toBeDeleted = _context.Set<TEntity>().FirstOrDefault(e => e.ID == ID);
                _context.Remove(toBeDeleted);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int ID)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.ID == ID);
        }

        public void Update(TEntity Entity)
        {
            try
            {
                _context.Set<TEntity>().Update(Entity);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public DbSet<TEntity> GetDbSet()
        {
            return _context.Set<TEntity>();
        }
    }
}
