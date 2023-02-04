namespace RealtimeRating.Domain.Entities
{
    public class Room
    {

        public Room()
        {
            RoomStudents = new HashSet<StudentRoom>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }

        public TeacherInfo Teacher { get; set; }

        public ICollection<StudentRoom> RoomStudents { get; set; }


    }
}
