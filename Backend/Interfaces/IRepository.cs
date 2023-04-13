using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Entities;

namespace Backend.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<Driver> GetAll();
        Driver GetById(int id);
        Driver Update(IEntityBase entity);
        void Delete(IEntityBase entity);
        void Register(IEntityBase entity);
    }
}