using Backend.Models.Dto.Vehicle;

namespace Backend.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Renavam { get; set; }
        public int Plate { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Year { get; set; }
        public int EntryDate { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int? SlotId { get; set; }
        public Slot? Slot { get; set; }
        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(RegisterVehicleDto dto) {
            Renavam = dto.Renavam;
            Plate = dto.Plate;
            VehicleTypeId = dto.VehicleTypeId;
            Year = dto.Year;
            EntryDate = dto.EntryDate;
            ModelId = dto.ModelId;
        }

    }
}
