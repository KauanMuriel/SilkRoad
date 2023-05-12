using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Dto.Driver
{
    public class GetDriverDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNH { get; set; }
        public string CPF { get; set; }
        public bool Admin { get; set; }
    
        public GetDriverDTO(Entities.Driver driver) {
            Id = driver.Id;
            Name = driver.Name;
            CNH = driver.CNH;
            CPF = driver.CPF;
            Admin = driver.Admin;
        }
    }
}