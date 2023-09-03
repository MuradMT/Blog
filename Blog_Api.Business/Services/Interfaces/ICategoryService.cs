using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Services.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryListItemDto>> GetAllAsync();
    Task<CategoryDetailDto> GetByIdAsync(int id);
    Task CreateAsync(CategoryCreateDto dto);
    Task UpdateAsync(int id,CategoryUpdateDto dto);
    Task DeleteAsync(int id);
}
