using Blog.Entity.Entities;

namespace Blog.Service.Services.Abstractions;

public interface IArticleService
{
    Task<IList<Article>> GetAllArticlesAsync();
}