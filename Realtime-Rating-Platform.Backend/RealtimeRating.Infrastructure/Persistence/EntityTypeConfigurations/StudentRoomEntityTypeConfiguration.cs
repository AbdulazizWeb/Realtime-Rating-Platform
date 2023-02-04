using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class StudentRoomEntityTypeConfiguration : IEntityTypeConfiguration<StudentRoom>
    {
        public void Configure(EntityTypeBuilder<StudentRoom> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Room)
                .WithMany(x => x.RoomStudents)
                .HasForeignKey(x => x.RoomId);

            builder.HasOne(x => x.StudentGroup)
                .WithMany(x => x.StudentRooms)
                .HasForeignKey(x => x.StudentGroupId);
        }
    }
}
