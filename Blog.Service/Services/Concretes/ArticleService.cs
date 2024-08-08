using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;

namespace Blog.Service.Services.Concretes;

public class ArticleService(IUnitOfWork _unitOfWork):IArticleService
{
    public async Task<IList<Article>> GetAllArticlesAsync()
    {
        return await _unitOfWork.GetRepository<Article>().GetAllAsync();
    }
}