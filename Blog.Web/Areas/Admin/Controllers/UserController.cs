using AutoMapper;
using Blog.Core.ResultMessages;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Dtos.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Data;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class UserController(UserManager<AppUser> _userManager, IToastNotification toast, RoleManager<AppUser> _roleManager, IMapper _mapper) : Controller
{
    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        var result = _mapper.Map<List<UserDto>>(users);

        foreach (var user in result)
        {
            var findUser = await _userManager.FindByIdAsync(user.Id.ToString());
            var role = string.Join("", await _userManager.GetRolesAsync(findUser));

            user.Role = role;
        }
        return View(result);
    }
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var roles = await _roleManager.Roles.ToListAsync();
        return View(new UserAddDto() { Roles = roles });
    }
    [HttpPost]
    public async Task<IActionResult> Add(UserAddDto userAddDto)
    {
        var map = _mapper.Map<AppUser>(userAddDto);
        var roles = await _roleManager.Roles.ToListAsync();
        if (ModelState.IsValid)
        {
            map.UserName = userAddDto.Email;
            var result = await _userManager.CreateAsync(map,string.IsNullOrEmpty(userAddDto.Password)?"":userAddDto.Password);
            if (result.Succeeded)
            {
                var findRole = await _roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                await _userManager.AddToRoleAsync(map, findRole.ToString());
                toast.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = Messages.Succesfully_Added });
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var errors in result.Errors) ModelState.AddModelError("", errors.Description);
                return View(new UserAddDto() { Roles = roles });
            }
        }
        return View(new UserAddDto() { Roles = roles });
    }
}
