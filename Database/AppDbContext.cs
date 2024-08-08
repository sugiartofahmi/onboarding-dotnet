using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database.Entities;
using onboarding_backend.Database.Seeders;

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
        public DbSet<MovieSchedule> MovieSchedules { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public override int SaveChanges()
        {
            UpdateTimestamps();
            return base.SaveChanges();
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateTimestamps()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is Base && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((Base)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Base)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                           .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<Tag>()
            .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<Studio>()
           .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<OrderItem>()
            .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<Order>()
           .HasQueryFilter(m => m.DeletedAt == null);

            modelBuilder.Entity<MovieSchedule>()
          .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<Movie>()
                .HasQueryFilter(m => m.DeletedAt == null);

            modelBuilder.Entity<Movie>()
               .HasMany(e => e.Tags)
               .WithMany(e => e.Movies)
               .UsingEntity(
                   "movie_tags",
                   l => l.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagId").HasPrincipalKey(nameof(Tag.Id)),
                   r => r.HasOne(typeof(Movie)).WithMany().HasForeignKey("MovieId").HasPrincipalKey(nameof(Movie.Id)),
                   j => j.HasKey("MovieId", "TagId"));

            new StudioSeeder(modelBuilder);
            new UserSeeder(modelBuilder);
            new TagSeeder(modelBuilder);

        }
    }
}