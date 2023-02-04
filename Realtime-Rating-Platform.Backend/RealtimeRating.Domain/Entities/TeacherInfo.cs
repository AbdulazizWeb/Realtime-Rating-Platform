namespace RealtimeRating.Domain.Entities
{
    public class TeacherInfo
    {

        public TeacherInfo()
        {
            Rooms = new HashSet<Room>(); 
            Groups = new HashSet<Group>();
        }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }
        public int TeacherId { get; set; }

        public User Teacher { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Group> Groups { get; set; }

    }
}
