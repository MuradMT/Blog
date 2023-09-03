using Blog_Api.Business.Dtos.BlogDtos;
using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Core.Entities;

namespace Blog_Api.Business.Services.Interfaces;

public interface IBlogService
{
    Task<IEnumerable<BlogListItemDto>> GetAllAsync();
    Task<BlogDetailDto> GetByIdAsync(int id);
    Task CreateAsync(BlogCreateDto dto);
    Task UpdateAsync(int id, BlogUpdateDto dto);
    Task DeleteAsync(int id);
    Task ReactAsync(int id,Reactions reaction);
    Task RemoveReactAsync(int id);
}
