using Blog_Api.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Blog_Api.DataAccess.Configurations;
public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.Property(b => b.Title).IsRequired().HasMaxLength(255);
        builder.Property(b => b.Description).IsRequired().HasMaxLength(255);
        builder.Property(b => b.CoverImageUrl).IsRequired();
        builder.Property(b => b.ViewerCount).HasDefaultValue(0);
        builder.Property(b => b.CreatedTime).HasDefaultValueSql("getutcdate()");
        builder.HasOne(b => b.AppUser).WithMany(u => u.Blogs).HasForeignKey(b => b.AppUserId);

    }
}

