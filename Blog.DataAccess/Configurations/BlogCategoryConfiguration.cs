using Blog_Api.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Blog_Api.DataAccess.Configurations;
public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
{
    public void Configure(EntityTypeBuilder<BlogCategory> builder)
    {
        builder.HasOne(b => b.Blog)
             .WithMany(b => b.BlogCategories)
             .HasForeignKey(bc => bc.BlogId);
        builder.HasOne(bc => bc.Category)
            .WithMany(c => c.BlogCategories)
            .HasForeignKey(bc => bc.CategoryId);
        builder.Ignore(i => i.IsDeleted);
    }
}

