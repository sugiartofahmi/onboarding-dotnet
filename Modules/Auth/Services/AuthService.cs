using onboarding_backend.Common.Middlewares;
using onboarding_backend.Common.Utils;
using onboarding_backend.Dtos.Auth;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Auth.Repositories;

namespace onboarding_backend.Modules.Auth.Services
{
    public class AuthService(AuthRepository authRepository)
    {
        private AuthRepository _authRepository = authRepository;
        public async Task<IUser> Login(LoginDto data)
        {
            var user = await _authRepository.FindUser(data.Email);
            if (user is null)
            {
                throw new NotFoundException("User not found");
            }
            bool isPasswordValid = PasswordUtils.VerifyPassword(data.Password, user.Password);

            if (!isPasswordValid)
            {
                throw new UnauthorizedAccessException("Invalid password");
            }

            return user;

        }

        public async Task Register(RegisterDto data)
        {
            await _authRepository.AddUser(data);
        }

    }
}