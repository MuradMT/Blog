using AutoMapper;
using Blog_Api.Business.Dtos.CategoryDtos;
using Blog_Api.Business.Exceptions.Category;
using Blog_Api.Business.Exceptions.Commons;
using Blog_Api.Business.ExtensionServices.Interfaces;
using Blog_Api.Business.Services.Interfaces;
using Blog_Api.Core.Entities;
using Blog_Api.DataAccess.Repositories.Abstract;

namespace Blog_Api.Business.Services.Implements;

public class CategoryService : ICategoryService
{
    readonly ICategoryRepository _repository;
    readonly IFileService _fileService;
    readonly IMapper _mapper;
    public CategoryService(ICategoryRepository repository, IFileService fileService, IMapper mapper)
    {
        _repository = repository;
        _fileService = fileService;
        _mapper = mapper;
    }

    public async Task CreateAsync(CategoryCreateDto dto)
    {
        Category category = new Category()
        {
            Name = dto.Name,
            LogoUrl = await _fileService.UploadAsync(dto.Logo,Path.Combine("images","img")),
            IsDeleted = false,

        };
      await _repository.CreateAsync(category);
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _ValidationCategory(id);
        await _repository.DeleteAsync(entity);
        await _repository.SaveAsync();
    }


    public async Task UpdateAsync(int id,CategoryUpdateDto dto)
    {
        var entity = await _ValidationCategory(id);
        _mapper.Map(dto, entity);
        entity.LogoUrl = await _fileService.UploadAsync(dto.Logo, Path.Combine("images", "img"));
        await _repository.SaveAsync();
    }

   public async Task<IEnumerable<CategoryListItemDto>> GetAllAsync()
    {
       return _mapper.Map<IEnumerable<CategoryListItemDto>>(_repository.GetAll());
    }

   public async Task<CategoryDetailDto> GetByIdAsync(int id)
    {
        var entity = await _ValidationCategory(id);
        return  _mapper.Map<CategoryDetailDto>(entity);
    }
    async Task<Category> _ValidationCategory(int id)
    {
        if (id <= 0) throw new NegativeIdException();
        var entity = await _repository.FindByIdAsync(id);
        if (entity == null) throw new CategoryException();
        return entity;
    }
}
