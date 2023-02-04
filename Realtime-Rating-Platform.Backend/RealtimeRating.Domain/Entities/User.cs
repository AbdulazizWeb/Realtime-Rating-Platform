using RealtimeRating.Domain.Enums;

namespace RealtimeRating.Domain.Entities
{
    public class User
    {
        public User()
        {
            Teachers = new HashSet<TeacherInfo>();
            Students = new HashSet<StudentInfo>();
        }

        public int Id { get; set; }
        public int Fullname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }

        public ICollection<TeacherInfo> Teachers { get; set; }
        public ICollection<StudentInfo> Students { get; set; }
    }
}
