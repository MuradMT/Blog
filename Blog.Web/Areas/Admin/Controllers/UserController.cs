using AutoMapper;
using Blog.Entity.Dtos.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class UserController(UserManager<AppUser> _userManager,IMapper _mapper): Controller
{
    public async Task<IActionResult> Index()
    {
        var users=await _userManager.Users.ToListAsync();
        var result = _mapper.Map<List<UserDto>>(users);

        foreach (var user in result)
        {
            var findUser =await _userManager.FindByIdAsync(user.Id.ToString());
            var role=string.Join("",await _userManager.GetRolesAsync(findUser));

            user.Role = role;
        }
        return View(result);
    }
}
