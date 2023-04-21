namespace Backend.Models.Entities
{
    public class Slot
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public Garage Garage { get; set; }

        public Slot()
        {

        }
    }
}
