namespace Blog_Api.Business.Dtos.UserAuthDtos;

public class UserWithRoleDto
{
    public AuthorDto User { get; set; }
    public IEnumerable<string> Roles { get; set; }
}
