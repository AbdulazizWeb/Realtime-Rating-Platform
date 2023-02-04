using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<StudentInfo>
    {
        public void Configure(EntityTypeBuilder<StudentInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.StudentId);
        }
    }
}
