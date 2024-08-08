using System.Diagnostics;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Blog.Web.Models;

namespace Blog.Web.Controllers;

public class HomeController(ILogger<HomeController> _logger,IArticleService _articleService): Controller
{
    public async Task<IActionResult> Index()
    {
        var articles = await _articleService.GetAllArticlesAsync();
        return View(articles);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}