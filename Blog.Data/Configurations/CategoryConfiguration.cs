using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(new Category()
        {
            Id = Guid.Parse("DFB950AD-E959-463F-AB3F-84658D5D4695"),
            Name = "Asp.Net Core",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
        },
        new Category()
        {
            Id = Guid.Parse("5D54BA1A-6F8A-410D-9A92-8800FEEA5415"),
            Name = "Visual Studio",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
        });
    }
}