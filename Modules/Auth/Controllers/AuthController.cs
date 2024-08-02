using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Modules.Auth.Services;

namespace onboarding_backend.Modules.Auth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController(AuthService authService)
    {
        private readonly AuthService _authService = authService;
        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            return null;

        }

        [HttpPost("register")]
        public async Task<ActionResult> Register()
        {
            return null;

        }


    }
}