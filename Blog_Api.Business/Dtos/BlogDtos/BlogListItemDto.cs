using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Business.Dtos.UserAuthDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Dtos.BlogDtos;

public class BlogListItemDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int ViewewCount { get; set; }
    public string CoverImageUrl { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedTime { get; set; }
    public AuthorDto AppUser { get; set; }
    //public IEnumerable<CategoryListItemDto> Categories { get; set; }
    public IEnumerable<BlogCategoryDto> BlogCategories { get; set; }
}
