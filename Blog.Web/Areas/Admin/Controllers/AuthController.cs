using Blog.Entity.Dtos.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers;

[Area("Admin")]

public class AuthController(UserManager<AppUser> _userManager,SignInManager<AppUser> _signInManager): Controller
{
     [HttpGet]
     public IActionResult Login()
     {
          return View();
     }
     
     [AllowAnonymous]
     [HttpPost]
     public async Task<IActionResult> Login(UserLoginDto userLoginDto)
     {
          if (ModelState.IsValid)
          {
               var user=await _userManager.FindByEmailAsync(userLoginDto.Email);
               if (user is not null)
               {
                    var result = 
                         await _signInManager.PasswordSignInAsync
                              (user, userLoginDto.Password,userLoginDto.RememberMe,false);
                    if (result.Succeeded)
                    {
                         return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else
                    {
                         ModelState.AddModelError("","Email or password is incorrect");
                         return View();
                    }
                    
               }
               else
               {
                    ModelState.AddModelError("","Email or password is incorrect");
                    return View();
               }
          }
          else
          {
               return View();  
          }
         
     }

     [Authorize]
     [HttpGet]
     public async Task<IActionResult> Logout()
     {
          await _signInManager.SignOutAsync();
          return RedirectToAction("Index", "Home", new { area = "" });
     }

}