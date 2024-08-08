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
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<StudioEntity> Studios { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<MovieScheduleEntity> MovieSchedules { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }

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
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>()
                           .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<TagEntity>()
            .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<StudioEntity>()
           .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<OrderItemEntity>()
            .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<OrderEntity>()
           .HasQueryFilter(m => m.DeletedAt == null);

            modelBuilder.Entity<MovieScheduleEntity>()
          .HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<MovieEntity>()
                .HasQueryFilter(m => m.DeletedAt == null);

            modelBuilder.Entity<MovieEntity>()
               .HasMany(e => e.Tags)
               .WithMany(e => e.Movies)
               .UsingEntity(
                   "movie_tags",
                   l => l.HasOne(typeof(TagEntity)).WithMany().HasForeignKey("TagId").HasPrincipalKey(nameof(TagEntity.Id)),
                   r => r.HasOne(typeof(MovieEntity)).WithMany().HasForeignKey("MovieId").HasPrincipalKey(nameof(MovieEntity.Id)),
                   j => j.HasKey("MovieId", "TagId"));

            new StudioSeeder(modelBuilder);
            new UserSeeder(modelBuilder);
            new TagSeeder(modelBuilder);

        }
    }
}