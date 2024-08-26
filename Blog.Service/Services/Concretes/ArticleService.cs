using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System.Linq.Expressions;

namespace Blog.Service.Services.Concretes;

public class ArticleService(IUnitOfWork _unitOfWork, IMapper _mapper) : IArticleService
{
    public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
    {
        var userId = Guid.Parse("E9EDE6B0-9D0D-48B1-A4A0-05FD5130E067");
        var imageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7");
        var article = new Article(articleAddDto.Title, articleAddDto.Content, articleAddDto.CategoryId, userId, imageId);
       
        await _unitOfWork.GetRepository<Article>().AddAsync(article);
        await _unitOfWork.SaveAsync();
    }

    public async Task<IList<ArticleDto>> GetAllArticlesWithCategoriesNotDeletedAsync()
    {
        var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
        //alternative way- return _mapper.Map<IList<Article>,IList<ArticleDto>>(articles);
        return _mapper.Map<IList<ArticleDto>>(articles);
    }
    public async Task<ArticleDto> GetArticleWithCategoriesNotDeletedAsync(Guid articleId)
    {
        var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted&&x.Id==articleId, x => x.Category);
        return _mapper.Map<ArticleDto>(article);
    }

    public async Task<string> UpdateAsync(ArticleUpdateDto articleUpdateDto)
    {
        var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category);

        article.Title = articleUpdateDto.Title;
        article.Content = articleUpdateDto.Content;
        article.CategoryId = articleUpdateDto.CategoryId;

        await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
        await _unitOfWork.SaveAsync();
        return article.Title;
    }
    public async Task<string> SafeDeleteArticleAsync(Guid articleId)
    {
        var article = await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
        article.IsDeleted = true;
        article.DeletedDate = DateTime.Now;
        await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
        await _unitOfWork.SaveAsync();
        return article.Title;
    }
}