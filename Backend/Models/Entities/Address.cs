namespace Backend.Models.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }

        public Address()
        {

        }
    }
}
