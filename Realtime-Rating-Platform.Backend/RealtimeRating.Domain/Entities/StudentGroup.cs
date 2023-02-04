namespace RealtimeRating.Domain.Entities
{
    public class StudentGroup
    {

        public StudentGroup()
        {
            StudentRooms = new HashSet<StudentRoom>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public bool IsPayed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }

        public StudentInfo Student { get; set; }
        public Group Group { get; set; }

        public ICollection<StudentRoom> StudentRooms { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
