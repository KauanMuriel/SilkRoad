using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.Dto
{
    public class RegisterModelDTO
    {
        public string Name { get; set; }
        public int BrandId { get; set; }

        public RegisterModelDTO()
        {

        }
    }
}