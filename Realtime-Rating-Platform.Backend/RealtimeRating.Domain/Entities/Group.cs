namespace RealtimeRating.Domain.Entities
{
    public class Group
    {

        public Group()
        {
            GroupStudents = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }

        public TeacherInfo Teacher { get; set; }

        public ICollection<StudentGroup> GroupStudents { get; set; }


    }
}
