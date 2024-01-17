using Lesson12.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lesson12.Data
{
    public class ShellDbContext : IdentityDbContext<User>
    {
        public ShellDbContext(DbContextOptions<ShellDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Shell> Shells { get; set; }
        public DbSet<Models.Entities.Type> AnimalTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasOne(a => a.Type)
                .WithMany(t => t.Animals)
                .HasForeignKey(a => a.TypeId);

            builder.Entity<Shell>()
                .HasMany(s => s.Animals)
                .WithOne(a => a.Shell)
                .HasForeignKey(a => a.ShellId);

            base.OnModelCreating(builder);
        }
    }
}
