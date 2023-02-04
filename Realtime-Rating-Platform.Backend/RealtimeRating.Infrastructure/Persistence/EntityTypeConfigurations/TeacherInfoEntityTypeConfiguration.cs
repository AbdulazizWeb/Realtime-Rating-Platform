using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class TeacherEntityTypeConfiguration : IEntityTypeConfiguration<TeacherInfo>
    {
        public void Configure(EntityTypeBuilder<TeacherInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Teachers)
                .HasForeignKey(x => x.TeacherId);
        }
    }
}
