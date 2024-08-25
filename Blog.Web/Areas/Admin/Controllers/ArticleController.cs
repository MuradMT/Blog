using AutoMapper;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class ArticleController(IArticleService 
    _articleService,ICategoryService _categoryService,IMapper _mapper,IValidator<Article> validator): Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var result= await _articleService.GetAllArticlesWithCategoriesNotDeletedAsync();
        return View(result);
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var categories = await _categoryService.GetAllCategoriesNonDeleted();
        return View(new ArticleAddDto { Categories=categories});
    }
    [HttpPost]
    public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
    {
        var map=_mapper.Map<Article>(articleAddDto);
        var result=await validator.ValidateAsync(map);

        if (result.IsValid)
        {

            await _articleService.CreateArticleAsync(articleAddDto);
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
        else
        {
            result.AddToModelState(this.ModelState);
            var categories = await _categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
      
    }
    [HttpGet]
    public async Task<IActionResult> Update(Guid articleId)
    {
        var article = await _articleService.GetArticleWithCategoriesNotDeletedAsync(articleId);
        var categories = await _categoryService.GetAllCategoriesNonDeleted();

        var articleUpdateDto=_mapper.Map<ArticleUpdateDto>(article);
        articleUpdateDto.Categories = categories;
        return View(articleUpdateDto);
    }
    [HttpPost]
    public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
    {
        var map = _mapper.Map<Article>(articleUpdateDto);
        var result = await validator.ValidateAsync(map);

        if (result.IsValid)
        {

            await _articleService.UpdateAsync(articleUpdateDto);
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
        else
        {
            result.AddToModelState(this.ModelState);
            var categories = await _categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleUpdateDto { Categories = categories });
        }
       
    }
    [HttpGet]
    public async Task<IActionResult> Delete(Guid articleId)
    {
        await _articleService.SafeDeleteArticleAsync(articleId);
        return RedirectToAction("Index", "Article", new { Area = "Admin" });
    }
}