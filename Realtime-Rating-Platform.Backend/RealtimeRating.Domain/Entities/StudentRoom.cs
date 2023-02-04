namespace RealtimeRating.Domain.Entities
{
    public class StudentRoom
    {

        public StudentRoom()
        {
            LessonTasks = new HashSet<LessonTask>();
        }

        public int Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public int StudentGroupId { get; set; }
        public int RoomId { get; set; }

        public StudentGroup StudentGroup { get; set; }
        public Room Room { get; set; }

        public ICollection<LessonTask> LessonTasks { get; set; }


    }
}
