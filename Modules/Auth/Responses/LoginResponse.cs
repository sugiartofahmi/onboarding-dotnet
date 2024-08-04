using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Auth.Responses
{
    public class LoginResponse
    {
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }

    }
}