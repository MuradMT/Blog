using Blog_Api.Business.Dtos.UserDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.ExternalServices.Interfaces;

public interface ITokenService
{
    TokenResponseDto CreateToken(AppUser user, int expires = 60);
}
