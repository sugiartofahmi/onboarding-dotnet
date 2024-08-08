using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Utils;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Auth;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Auth.Repositories
{
    public class AuthRepository(AppDbContext context)
    {
        public AppDbContext _context = context;

        public async Task<IUser?> FindUser(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> AddUser(RegisterDto data)
        {
            var user = new Database.Entities.User
            {
                Email = data.Email,
                Password = PasswordUtils.HashPassword(data.Password),
                Avatar = data.Avatar,
                Name = data.Name
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}