using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Entities;

namespace Backend.Interfaces
{
    public interface IDriverRepository
    {
        Driver GetById(int id);
    }
}