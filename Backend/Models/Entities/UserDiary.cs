namespace Backend.Models.Entities
{
    public class UserDiary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public UserDiary() {
        
        }
    }
}
