using Blog_Api.Business.Dtos.CommentDtos;
using Blog_Api.Business.Dtos.UserAuthDtos;

namespace Blog_Api.Business.Dtos.BlogDtos;

public class BlogDetailDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int ViewerCount { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedTime { get; set; }
    public AuthorDto AppUser { get; set; }
    public IEnumerable<BlogCategoryDto> blogCategories  { get; set; }
    public IEnumerable<CommentListItemDto> Comments  { get; set; }
}
