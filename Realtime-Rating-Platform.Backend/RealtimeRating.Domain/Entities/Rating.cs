namespace RealtimeRating.Domain.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public string Rate { get; set; }
        public int StudentGroupId { get; set; }
        public int LessonId { get; set;}

        public StudentGroup StudentGroup { get; set; }
        public LessonTask LessonTasks { get; set; }
    }
}
