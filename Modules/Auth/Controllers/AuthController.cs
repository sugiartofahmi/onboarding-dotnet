using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Auth;
using onboarding_backend.Interfaces;
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
            var user = new Database.Entities.User
            {
                Email = request.Email,
                Password = request.Password,
                Avatar = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png"
            };
            return new ApiResponse(data: user, success: true, message: "Success");

        }

        [HttpPost("register")]
        public async Task<ActionResult<ApiResponse>> Register([FromBody] RegisterDto request)
        {
            var user = new Database.Entities.User
            {
                Email = request.Email,
                Password = request.Password,
                Avatar = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png"
            };
            return new ApiResponse(data: user, success: true, message: "Success");

        }


    }
}