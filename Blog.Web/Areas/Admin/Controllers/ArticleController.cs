using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class ArticleController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}