namespace RealtimeRating.Domain.Entities
{
    public class StudentInfo
    {

        public StudentInfo()
        {
            StudentGroups = new HashSet<StudentGroup>();
        }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public int StudentId { get; set; }

        public User Student { get; set; }

        public ICollection<StudentGroup> StudentGroups { get; set; }

    }
}
