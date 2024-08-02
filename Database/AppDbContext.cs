using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MovieTag> MovieTags { get; set; }
        public DbSet<MovieSchedule> MovieSchedules { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}