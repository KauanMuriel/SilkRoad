namespace Backend.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int DiaryId { get; set; }
        public Diary Diary { get; set; }

        public Event()
        {

        }
    }
}
