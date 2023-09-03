using Blog_Api.Business.Dtos.BlogDtos;
using Microsoft.AspNetCore.Identity;

namespace Blog_Api.Business.Services.Interfaces;

public interface IRoleService
{
    Task<IEnumerable<IdentityRole>> GetAllAsync();
    Task<string> GetByIdAsync(string id);
    Task CreateAsync(string name);
    Task UpdateAsync(string id,string name);
    Task RemoveAsync(string id);
}
