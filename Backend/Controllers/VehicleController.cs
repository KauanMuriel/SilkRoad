using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models.Dto.Vehicle;
using Backend.Models.Entities;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleRepository _repository;

        public VehicleController(VehicleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _repository.GetById(id);

            if (vehicle is not null)
            {
                return Ok(vehicle);
            }
            else
            {
                return NotFound(new { message = "The vehicle was not found!" });
            }
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var vehicles = _repository.GetAll();

            if (vehicles is not null)
            {
                return Ok(vehicles);
            }
            else
            {
                return NotFound(new { message = "There aren't vehicles registered!" });
            }
        }

        [HttpPost]
        public IActionResult Register(RegisterVehicleDto dto) {
            var vehicle = new Vehicle(dto);
            _repository.Register(vehicle);
            return Ok();
        }
    }
}