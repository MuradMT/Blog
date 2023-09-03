using Blog_Api.Business.Dtos.UserAuthDtos;
using Blog_Api.Business.Dtos.UserDtos;

namespace Blog_Api.Business.Services.Interfaces;

public interface IUserService
{
    Task Register(RegisterDto dto);
    Task<TokenResponseDto> Login(LoginDto dto);
    Task<ICollection<UserWithRoleDto>> GetAllAsync();
    Task AddRoleAsync(string roleName, string userName);
    
}
