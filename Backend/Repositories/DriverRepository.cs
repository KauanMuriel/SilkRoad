using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Interfaces;
using Backend.Models.Entities;

namespace Backend.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly GestaoContext _context;
        public DriverRepository(GestaoContext context) {
            _context = context;
        }

        public Driver GetById(int id) => _context.Drivers.Find(id);

        public List<Driver> GetAll() => _context.Drivers.ToList();
    }
}