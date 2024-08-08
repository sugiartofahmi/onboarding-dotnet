using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Database.Seeders
{
    public class StudioSeeder
    {
        public StudioSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studio>().HasData(
                 new Studio { Id = 1, StudioNumber = 1, SeatCapacity = 10, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                  new Studio { Id = 2, StudioNumber = 2, SeatCapacity = 15, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
        }
    }
}