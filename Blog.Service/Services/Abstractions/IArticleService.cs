using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;

namespace Blog.Service.Services.Abstractions;

public interface IArticleService
{
    Task<IList<ArticleDto>> GetAllArticlesWithCategoriesNotDeletedAsync();
    Task CreateArticleAsync(ArticleAddDto articleAddDto);
    Task<ArticleDto> GetArticleWithCategoriesNotDeletedAsync(Guid articleId);
    Task<string> UpdateAsync(ArticleUpdateDto articleUpdateDto);
    Task<string> SafeDeleteArticleAsync(Guid articleId);
}