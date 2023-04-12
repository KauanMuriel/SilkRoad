namespace Backend.Models.Entities
{
    public class Garage
    {
        public int Id { get; set; }
        public int Slots { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public Garage() {
        
        }
    }
}
