using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Auth.Responses
{
    public class LoginResponse
    {
        public string email;
        public string password;
        public string avatar;
        public IToken token;

    }
}