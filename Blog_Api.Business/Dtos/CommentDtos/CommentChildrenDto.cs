using Blog_Api.Business.Dtos.UserAuthDtos;

namespace Blog_Api.Business.Dtos.CommentDtos;

public record CommentChildrenDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public AuthorDto AppUser { get; set; }
}
