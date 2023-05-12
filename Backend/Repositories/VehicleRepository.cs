using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Dto.Driver;
using Backend.Models.Entities;

namespace Backend.Repositories
{
    public class VehicleRepository
    {
        private readonly GestaoContext _context;

        public VehicleRepository(GestaoContext context)
        {
            _context = context;
        }

        public void Register(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public Vehicle GetById(int id) => _context.Vehicles.Find(id);

        public List<Vehicle> GetAll() => _context.Vehicles.ToList();

        public void Delete(Vehicle vehicle)
        {
            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();
        }
    }
}