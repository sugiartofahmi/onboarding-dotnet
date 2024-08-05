using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Database.Seeders
{
    public class TagSeeder
    {
        public TagSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "Action" },
                new Tag { Id = 2, Name = "Comedy" },
                new Tag { Id = 3, Name = "Drama" },
                new Tag { Id = 4, Name = "Horror" },
                new Tag { Id = 5, Name = "Romance" },
                new Tag { Id = 6, Name = "Science Fiction" },
                new Tag { Id = 7, Name = "Fantasy" },
                new Tag { Id = 8, Name = "Thriller" },
                new Tag { Id = 9, Name = "Mystery" },
                new Tag { Id = 10, Name = "Documentary" }
            );
        }
    }
}