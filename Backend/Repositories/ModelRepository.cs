using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Context;
using Backend.Models.Entities;

namespace Backend.Repositories
{
    public class ModelRepository
    {
        private readonly GestaoContext _context;

        public ModelRepository(GestaoContext context)
        {
            _context = context;
        }

        public void Register(Model model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
        }

        public Model GetById(int id) => _context.Models.Find(id);

        public List<Model> GetAll() => _context.Models.ToList();
    }
}