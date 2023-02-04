using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class lessonTaskEntityTypeConfiguration : IEntityTypeConfiguration<LessonTask>
    {
        public void Configure(EntityTypeBuilder<LessonTask> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.StudentRoom)
                .WithMany(x => x.LessonTasks)
                .HasForeignKey(x => x.StudentRoomId);
        }
    }
}
