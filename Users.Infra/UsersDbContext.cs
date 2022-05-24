using Microsoft.EntityFrameworkCore;
using Users.Model;

namespace Users.Infra
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; }
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
            Database.EnsureCreated();
            Users = Set<User>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}