using Microsoft.EntityFrameworkCore;
using RealtimeRating.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeRating.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<TeacherInfo> Teachers { get; set; }
        DbSet<StudentInfo> Students { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<StudentGroup> StudentGroups { get; set; }
        DbSet<StudentRoom> StudentRooms { get; set; }
        DbSet<LessonTask> LessonTasks { get; set; }
        DbSet<Rating> Ratings { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
