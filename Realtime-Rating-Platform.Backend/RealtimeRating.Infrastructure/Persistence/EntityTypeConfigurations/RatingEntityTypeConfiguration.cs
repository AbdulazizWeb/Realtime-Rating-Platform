using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class RatingEntityTypeConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.StudentGroup)
                .WithMany(x => x.Ratings)
                .HasForeignKey(x => x.StudentGroupId);


            builder.HasOne(x => x.LessonTask)
                .WithMany(x => x.Ratings)
                .HasForeignKey(x => x.LessonTaskId);
        }
    }
}
