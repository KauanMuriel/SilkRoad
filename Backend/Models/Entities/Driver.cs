using Backend.Interfaces;
using Backend.Models.Dto.Driver;

namespace Backend.Models.Entities
{
    public class Driver : User
    {
        public string CNH { get; set; }

        public Driver()
        {
        }

        public Driver(RegisterDriverDTO dto)
        {
            Name = dto.Name;
            CPF = dto.CPF;
            CNH = dto.CNH;
            Admin = dto.Admin;
        }
    }
}
