using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Helpers.Images;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Blog.Service.Services.Concretes;

public class ArticleService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor accessor,IImageHelper imageHelper) : IArticleService
{
    private readonly ClaimsPrincipal _principal = accessor.HttpContext.User;

    public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
    {
        var userId = _principal.GetLoggedInUserId(); //Guid.Parse("E9EDE6B0-9D0D-48B1-A4A0-05FD5130E067");
        var userEmail=_principal.GetLoggedInEmail();

        //var imageId = Guid.Parse("3224267D-94E7-4501-A7F3-0D376C3060A7");

        var imageUpload = await imageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);
        Image image = new(imageUpload.FullName,articleAddDto.Photo.ContentType,userEmail);
        await unitOfWork.GetRepository<Image>().AddAsync(image);

        var article = new Article(articleAddDto.Title, articleAddDto.Content, articleAddDto.CategoryId, userId,userEmail, image.Id);
       
        await unitOfWork.GetRepository<Article>().AddAsync(article);
        await unitOfWork.SaveAsync();
    }

    public async Task<IList<ArticleDto>> GetAllArticlesWithCategoriesNotDeletedAsync()
    {
        var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
        //alternative way- return _mapper.Map<IList<Article>,IList<ArticleDto>>(articles);
        return mapper.Map<IList<ArticleDto>>(articles);
    }
    public async Task<ArticleDto> GetArticleWithCategoriesNotDeletedAsync(Guid articleId)
    {
        var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted&&x.Id==articleId, x => x.Category,x=>x.Image);
        return mapper.Map<ArticleDto>(article);
    }

    public async Task<string> UpdateAsync(ArticleUpdateDto articleUpdateDto)
    {
        var userEmail = _principal.GetLoggedInEmail();
        var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id,
            x => x.Category,i=>i.Image);

        if(articleUpdateDto.Photo != null)
        {
            imageHelper.Delete(article.Image.FileName);
            var imageUpload=await imageHelper.Upload(articleUpdateDto.Title,articleUpdateDto.Photo,ImageType.Post);
            Image image = new(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);
            article.ImageId = image.Id;
        }

        article.Title = articleUpdateDto.Title;
        article.Content = articleUpdateDto.Content;
        article.CategoryId = articleUpdateDto.CategoryId;
        article.ModifiedDate=DateTime.Now;
        article.ModifiedBy = userEmail;

        await unitOfWork.GetRepository<Article>().UpdateAsync(article);
        await unitOfWork.SaveAsync();
        return article.Title;
    }
    public async Task<string> SafeDeleteArticleAsync(Guid articleId)
    {
        var userEmail = _principal.GetLoggedInEmail();
        var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
        article.IsDeleted = true;
        article.DeletedDate = DateTime.Now;
        article.DeletedBy = userEmail;
        await unitOfWork.GetRepository<Article>().UpdateAsync(article);
        await unitOfWork.SaveAsync();
        return article.Title;
    }
}