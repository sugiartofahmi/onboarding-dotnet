using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Common.Utils;
using onboarding_backend.Dtos.Auth;
using onboarding_backend.Modules.Auth.Responses;
using onboarding_backend.Modules.Auth.Services;

namespace onboarding_backend.Modules.Auth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController(AuthService authService) : ControllerBase
    {
        private readonly AuthService _authService = authService;
        [HttpPost("login")]
        public async Task<ActionResult<ApiResponse>> Login([FromBody] LoginDto request)
        {
            var user = await _authService.Login(request);
            string token = TokenUtils.GenerateToken(user);
            var mapUser = new LoginResponse
            {
                Email = user.Email,
                Name = user.Name,
                Avatar = user.Avatar,
                Token = token
            };
            return new ApiResponse(data: mapUser, success: true, message: "Success");
        }

        [HttpPost("register")]
        public async Task<ActionResult<ApiResponse>> Register([FromBody] RegisterDto request)
        {
            await _authService.Register(request);
            return new ApiResponse(success: true, message: "Success");

        }

    }
}