using AutoMapper;
using Blog.Core.ResultMessages;
using Blog.Entity.Dtos.Categories;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService categoryService,IMapper mapper,IValidator<Category> validator,IToastNotification toast) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Add()
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name), new ToastrOptions { Title = Messages.Succesfully_Added });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name), new ToastrOptions { Title = Messages.Succesfully_Added });

                return Json(Messages.Category.Add(categoryAddDto.Name));
            }
            else
            {
                toast.AddErrorToastMessage(result.Errors.First().ErrorMessage, new ToastrOptions { Title = Messages.Failed_Operation });
                return Json(result.Errors.First().ErrorMessage);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await categoryService.GetCategoryByGuid(categoryId);
            var map = mapper.Map<Category, CategoryUpdateDto>(category);

            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = mapper.Map<Category>(categoryUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
                toast.AddSuccessToastMessage(Messages.Category.Update(name), new ToastrOptions { Title = Messages.Succesfully_Updated });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
                return View();
            }
        }
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var name = await categoryService.SafeDeleteCategoryAsync(categoryId);
            toast.AddSuccessToastMessage(Messages.Category.Delete(name), new ToastrOptions() { Title = Messages.Succesfully_Deleted });
            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }

    }
}
