using Blog_Api.Business.Dtos.UserAuthDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Dtos.BlogLikeDtos;

public class BlogLikeListItemDto
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public AuthorDto AppUser { get; set; }
    public Reactions Reaction { get; set; }
}
