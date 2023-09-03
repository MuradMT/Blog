using AutoMapper;
using Blog_Api.Business.Dtos.BlogDtos;
using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Profiles;

public class BlogMappingProfiles:Profile
{
    public BlogMappingProfiles()
    {
        CreateMap<Blog, BlogDetailDto>();
        CreateMap<Blog, BlogListItemDto>();
        CreateMap<BlogCreateDto, Blog>();
        CreateMap<BlogUpdateDto, Blog>();
        CreateMap<BlogCategory, BlogCategoryDto>();
    }
}
