using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class ImageConfiguration:IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(new Image()
        {
             Id = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7"),
             FileName = "images/testimage",
             FileType = "jpg",
             CreatedBy = "Admin Test",
             CreatedDate = DateTime.UtcNow,
             IsDeleted = false
             
        },new Image()
        {
            Id = Guid.Parse("4A34A0A9-367C-4A27-918D-4782C48A6384"),
            FileName = "images/vstest",
            FileType = "png",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
        });
    }
}