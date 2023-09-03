using AutoMapper;
using Blog_Api.Business.Dtos.UserAuthDtos;
using Blog_Api.Business.Dtos.UserDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Profiles;

public class UserMappingProfiles : Profile
{
    public UserMappingProfiles()
    {
        CreateMap<RegisterDto, AppUser>();
        CreateMap<AppUser, AuthorDto>();
    }
}

