using Backend.Models.Dto;

namespace Backend.Models.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public Model()
        {
        }

        public Model(RegisterModelDTO dto) {
            Name = dto.Name;
            BrandId = dto.BrandId;
        }

    }
}
