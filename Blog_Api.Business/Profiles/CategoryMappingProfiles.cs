using AutoMapper;
using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Profiles;

public class CategoryMappingProfiles:Profile
{
    public CategoryMappingProfiles() {
        CreateMap<Category, CategoryDetailDto>();
        CreateMap<Category, CategoryListItemDto>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto,Category>();
    }
}
