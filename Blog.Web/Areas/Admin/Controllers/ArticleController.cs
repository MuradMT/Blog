using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class ArticleController(IArticleService 
    _articleService): Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var result= await _articleService.GetAllArticlesWithCategoriesNotDeletedAsync();
        return View(result);
    }
}