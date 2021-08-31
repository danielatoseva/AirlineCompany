using AirlineCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AirlineCompany.BLL
{
    public class BusinessLayerConverter
    {
        
        public TEntity ParamsToEntity<TEntity>(ParameterInfo[] Parameters)
            where TEntity : Common, new()
        {
            throw new InvalidProgramException("Not possible");
            //    TEntity entity = new TEntity();

            //    foreach (string property in 
            //        entity.GetType()
            //        .GetProperties().Select(p => p.Name)
            //        .Intersect(Parameters.Select(par => par.Name)))

            //    {
            //        entity.GetType().GetProperty(property).SetValue(entity,
            //            Parameters.FirstOrDefault(par => par.Name == property)

            //            );
            //    }
        }
    }
}
