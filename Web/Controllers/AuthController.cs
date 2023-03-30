using BUS.IServices;
using DAL.Entities;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IQLUserService _qLUserService;
        
        public AuthController(IQLUserService qLUserService)
        {
            _qLUserService = qLUserService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest newUser)
        {
            try
            {
                await _qLUserService.Register(newUser);
                RegisterResponse response = new()
                {
                    user = newUser,
                    message = "Register successfully!"
                };
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            try
            {
                var account = await _qLUserService.Login(login);
                return Ok(account);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout([FromBody] LogoutRequest logout)
        {
            try
            {
                var account = await _qLUserService.Logout(logout.userId);
                return Ok(account);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
