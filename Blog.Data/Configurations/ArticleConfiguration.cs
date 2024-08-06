using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Configurations;

public class ArticleConfiguration:IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(150);

        builder.HasData(new Article()
            {
                 Id = Guid.NewGuid(),
                 Title = "Asp.Net Core",
                 Content = "Asp.net core lorem ipsum dolor solet",
                 ViewCount = 15,
                 CategoryId = Guid.Parse("DFB950AD-E959-463F-AB3F-84658D5D4695"),
                 ImageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7"),
                 CreatedBy = "Admin Test",
                 CreatedDate = DateTime.UtcNow,
                 IsDeleted = false
            },
            new Article()
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio",
                Content = "visual studio lorem ipsum dolor solet",
                ViewCount = 15,
                CategoryId = Guid.Parse("5D54BA1A-6F8A-410D-9A92-8800FEEA5415"),
                ImageId = Guid.Parse("4A34A0A9-367C-4A27-918D-4782C48A6384"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
            }
        );
    }
}