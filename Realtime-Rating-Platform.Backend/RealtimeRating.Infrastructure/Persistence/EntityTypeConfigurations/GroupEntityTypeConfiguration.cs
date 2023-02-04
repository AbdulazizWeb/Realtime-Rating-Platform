using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.TeacherId);
        }
    }
}
