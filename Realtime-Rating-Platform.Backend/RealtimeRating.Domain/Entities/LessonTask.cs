namespace RealtimeRating.Domain.Entities
{
    public class LessonTask
    {

        public LessonTask()
        {
            Ratings= new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StudentRoomId { get; set; }

        public StudentRoom StudentRoom { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
