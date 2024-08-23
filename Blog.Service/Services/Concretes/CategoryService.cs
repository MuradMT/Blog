using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Categories;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concretes
{
    public class CategoryService(IUnitOfWork _unitOfWork,IMapper _mapper): ICategoryService
    {
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories=await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            return _mapper.Map<List<CategoryDto>>(categories);
        }
    }
}
