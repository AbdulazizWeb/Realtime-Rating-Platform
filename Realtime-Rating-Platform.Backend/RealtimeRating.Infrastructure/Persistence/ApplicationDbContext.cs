using Microsoft.EntityFrameworkCore;
using RealtimeRating.Application.Abstractions;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TeacherInfo> Teachers { get; set; }
        public DbSet<StudentInfo> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentRoom> StudentRooms { get; set; }
        public DbSet<LessonTask> LessonTasks { get; set; }
        public DbSet<Rating> Ratings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    
    }
}
