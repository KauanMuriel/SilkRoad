namespace Backend.Models.Entities
{
    public class Slot
    {
        public int Id { get; set; }
        public int GarageID { get; set; }
        public Garage Garage { get; set; }

        public Slot()
        {

        }
    }
}
