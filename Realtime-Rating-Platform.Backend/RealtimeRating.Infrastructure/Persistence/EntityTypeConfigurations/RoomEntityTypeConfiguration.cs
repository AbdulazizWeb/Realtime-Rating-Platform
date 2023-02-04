using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.TeacherId);
        }
    }
}
