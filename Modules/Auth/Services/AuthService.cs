using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Modules.Auth.Repositories;

namespace onboarding_backend.Modules.Auth.Services
{
    public class AuthService(AuthRepository authRepository)
    {
        private AuthRepository _authRepository = authRepository;
        public async Task Login()
        {

        }

    }
}