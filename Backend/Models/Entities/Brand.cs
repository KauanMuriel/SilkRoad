using Backend.Models.Dto.Brand;

namespace Backend.Models.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brand()
        {
        }

        public Brand(RegisterBrandDTO dto)
        {
            Name = dto.Name;
        }
    }
}
