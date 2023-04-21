using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Dto.Vehicle
{
    public class RegisterVehicleDto
    {

        public string Renavam { get; set; }
        public int Plate { get; set; }
        public int VehicleTypeId { get; set; }
        public int Year { get; set; }
        public int EntryDate { get; set; }
        public int ModelId { get; set; }

        RegisterVehicleDto()
        {
        }
    }
}