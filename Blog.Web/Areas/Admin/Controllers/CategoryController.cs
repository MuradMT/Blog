using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService categoryService): Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories=await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }
    }
}
