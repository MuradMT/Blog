using Blog_Api.Business.Dtos.UserDtos;
using Blog_Api.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Api.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IUserService _service;
        public AuthController(IUserService service)
        { 
            _service = service;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>  Register(RegisterDto dto)
        {
           await  _service.Register(dto);
            return NoContent();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
           
            return Ok(await _service.Login(dto));
        }
    }
}
