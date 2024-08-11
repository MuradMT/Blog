using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;

namespace Blog.Service.Services.Concretes;

public class ArticleService(IUnitOfWork _unitOfWork,IMapper _mapper):IArticleService
{
    public async Task<IList<ArticleDto>> GetAllArticlesAsync()
    {
        var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync();
        //alternative way- return _mapper.Map<IList<Article>,IList<ArticleDto>>(articles);
        return _mapper.Map<IList<ArticleDto>>(articles);
    }
}