using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Entities;

namespace Backend.Repositories
{
    public class VehicleTypeRepository
    {
        private readonly GestaoContext _context;

        public VehicleTypeRepository(GestaoContext context)
        {
            _context = context;
        }

        public void Register(VehicleType vehicleType)
        {
            _context.VehiclesTypes.Add(vehicleType);
            _context.SaveChanges();
        }

        public VehicleType GetById(int id) => _context.VehiclesTypes.Find(id);

        public List<VehicleType> GetAll() => _context.VehiclesTypes.ToList();

        public void Delete(VehicleType vehicleType)
        {
            _context.VehiclesTypes.Remove(vehicleType);
            _context.SaveChanges();
        }
    }
}