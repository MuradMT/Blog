using AutoMapper;
using Blog_Api.Business.Dtos.CommentDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Profiles;

public class CommentMappingProfiles:Profile
{
    public CommentMappingProfiles()
    {
        CreateMap<Comment, CommentListItemDto>();
        CreateMap<CommentCreateDto, Comment>();
        CreateMap<CommentChildrenDto, Comment>().ReverseMap();
    }
}
