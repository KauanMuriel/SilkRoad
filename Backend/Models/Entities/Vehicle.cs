namespace Backend.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Renavem { get; set; }
        public int Plate { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Year { get; set; }
        public int EntryYear { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int SlotId { get; set; }
        public Slot Slot { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public Vehicle()
        {

        }

    }
}
