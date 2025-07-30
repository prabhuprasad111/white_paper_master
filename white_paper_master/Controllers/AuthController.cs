using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using white_paper_master.Helper;
using white_paper_master.Models;
using white_paper_master.Repository.Interfaces;
using white_paper_master.Services.Interfaces;
using static white_paper_master.Models.Common;

namespace white_paper_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.LOGIN_ID) || string.IsNullOrWhiteSpace(request.LOGIN_PASSWORD))
            {
                return BadRequest(ResponseHelper.Error<object>("Username and password are required.", 400));
            }

            var (token, offices) = await _authService.AuthenticateAsync(request.LOGIN_ID, request.LOGIN_PASSWORD);

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized(ResponseHelper.Error<object>("Invalid username or password.", 401));
            }

            return Ok(ResponseHelper.Success(new { Token = token, Offices = offices }, "Login successful", 1, offices.Count, offices.Count));
        }

    }


}
