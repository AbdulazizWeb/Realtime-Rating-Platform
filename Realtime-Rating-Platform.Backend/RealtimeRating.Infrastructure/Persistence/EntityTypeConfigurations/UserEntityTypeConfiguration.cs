﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealtimeRating.Domain.Entities;
using RealtimeRating.Domain.Enums;

namespace RealtimeRating.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.HasData(new User()
            {
                Id = 1,
                Email = "baxtiyorov1999@bk.ru",
                PasswordHash = "CA5B9811BE39C13BA3F8265C006761214B85F36FFE177C482AA548A30FC2C8994F5AE33790A4AE6A302B65A05A906AAED4912F02C0E69FC6CE14A9C90AD998A0",
                Role = UserRole.Admin,
                Fullname = "Abdulaziz Baxtiyorov"
            });
        }
    }
}
