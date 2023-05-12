using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Interfaces;
using Backend.Models.Dto.Driver;
using Backend.Models.Entities;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly DriverRepository _repository;

        public DriverController(DriverRepository repository) {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Driver driver = _repository.GetById(id);

            if (driver is not null)
            {
                return Ok(new GetDriverDTO(driver));
            }
            else
            {
                return NotFound(new { message = "Driver not found"});
            }
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var drivers = _repository.GetAll();
            
            if(drivers is not null)
            {
                var driversFormated = new List<GetDriverDTO>();

                foreach (var driver in drivers) {
                    driversFormated.Add(new GetDriverDTO(driver));
                }
                return Ok(driversFormated);
            }
            else
            {
                return NotFound(new { message = "There aren't drivers registered "});
            }
        }

        [HttpPost]
        public IActionResult Register(RegisterDriverDTO dto)
        {
            var driver = new Driver(dto);
            _repository.Register(driver);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var vehicle = _repository.GetById(id);

            if (vehicle is not null) {
                _repository.Delete(vehicle);
                return NoContent();
            }
            else {
                return NotFound(new { message = "Driver not found"});
            }
        }
    }
}