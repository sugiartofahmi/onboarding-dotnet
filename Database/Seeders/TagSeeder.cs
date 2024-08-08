using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Database.Seeders
{
    public class TagSeeder
    {
        public TagSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagEntity>().HasData(
                new TagEntity { Id = 1, Name = "Action", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 2, Name = "Comedy", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 3, Name = "Drama", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 4, Name = "Horror", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 5, Name = "Romance", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 6, Name = "Science Fiction", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 7, Name = "Fantasy", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 8, Name = "Thriller", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 9, Name = "Mystery", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new TagEntity { Id = 10, Name = "Documentary", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
        }
    }
}