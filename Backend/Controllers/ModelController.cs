using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models.Dto;
using Backend.Models.Entities;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelController : ControllerBase
    {
        private readonly ModelRepository _repository;

        public ModelController(ModelRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var model = _repository.GetById(id);

            if (model is not null) {
                return Ok(model);
            } else {
                return NotFound("Model not found!");
            }
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var models = _repository.GetAll();

            if (models is not null) {
                return Ok(models);
                
            } else {
                return NotFound("There aren't models registered!");
            }
        }

        [HttpPost]
        public IActionResult Register(RegisterModelDTO dto)
        {
            var model =  new Model(dto);
            _repository.Register(model);
            return Ok();
        }
    }
}