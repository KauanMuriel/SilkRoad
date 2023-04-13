using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Dto.Driver
{
    public class RegisterDriverDTO
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public bool Admin { get; set; }
    }
}