using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController(IArticleService _articleService) : Controller
    {
        // GET: HomeController
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticlesWithCategoriesNotDeletedAsync();
            return View(articles);
        }

    }
}
