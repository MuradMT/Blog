using Blog_Api.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Blog_Api.DataAccess.Configurations;
public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
        builder.Property(a => a.Surname).IsRequired().HasMaxLength(64);
        builder.Property(a => a.ImageUrl).IsRequired(false);

    }
}

