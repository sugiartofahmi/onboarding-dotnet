using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Utils;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Database.Seeders
{
    public class UserSeeder
    {
        public UserSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                 new UserEntity { Id = 1, Name = "Admin", Email = "admin@admin.com", Password = PasswordUtils.HashPassword("Admin123!"), Avatar = "https://static-00.iconduck.com/assets.00/avatar-default-symbolic-icon-479x512-n8sg74wg.png", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsAdmin = true }
            );
        }
    }
}