namespace Backend.Models.Entities
{
    public class Diary
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public Diary()
        {

        }
    }
}
