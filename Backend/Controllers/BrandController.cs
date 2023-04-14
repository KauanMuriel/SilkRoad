using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models.Dto.Brand;
using Backend.Models.Entities;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly BrandRepository _repository;

        public BrandController(BrandRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var brands = _repository.GetAll();

            if (brands is not null)
            {
                return Ok(brands);
            }
            else 
            {
                return NotFound(new { message = "There aren't brand registered!"});
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var brand = _repository.GetById(id);

            if (brand is not null)
            {
                return Ok(brand);
            }
            else 
            {
                return NotFound(new { message = "Brand not found!"});
            }
        }

        [HttpPost]
        public IActionResult Register(RegisterBrandDTO dto)
        {
            var brand = new Brand(dto);
            _repository.Register(brand);
            return Ok();
        }
    }
}