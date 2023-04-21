using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models.Entities;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleTypeController : ControllerBase
    {
        private readonly VehicleTypeRepository _repository;

        public VehicleTypeController(VehicleTypeRepository repository) {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehiType = _repository.GetById(id);

            if (vehiType is not null) {
                return Ok(vehiType);
            } else {
                return NotFound("Vehicle type not found!");
            }
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var vehiType = _repository.GetAll();

            if (vehiType is not null) {
                return Ok(vehiType);
                
            } else {
                return NotFound("There aren't vehicle types registered!");
            }
        }

        [HttpPost("name")]
        public IActionResult Register(string name)
        {
            var vehiType =  new VehicleType() { Name = name};

            _repository.Register(vehiType);
            return Ok();
        }
    }
}