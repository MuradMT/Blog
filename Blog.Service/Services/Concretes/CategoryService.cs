using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Categories;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concretes
{
    public class CategoryService(IUnitOfWork _unitOfWork,IMapper _mapper, IHttpContextAccessor httpContextAccessor) : ICategoryService
    {
        private readonly ClaimsPrincipal _user = httpContextAccessor.HttpContext.User;
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories=await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            return _mapper.Map<List<CategoryDto>>(categories);
        }
        public async Task CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            Category category = new(categoryAddDto.Name, userEmail);
            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            await _unitOfWork.SaveAsync();

        }
    }
}
