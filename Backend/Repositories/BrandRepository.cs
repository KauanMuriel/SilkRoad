using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Entities;

namespace Backend.Repositories
{
    public class BrandRepository
    {
        private readonly GestaoContext _context;

        public BrandRepository(GestaoContext context)
        {
            _context = context;
        }

        public List<Brand> GetAll() => _context.Brands.ToList();

        public Brand GetById(int id) => _context.Brands.Find(id);

        public void Register(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public void Delete(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }
    }
}