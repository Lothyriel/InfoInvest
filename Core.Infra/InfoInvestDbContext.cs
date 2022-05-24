using Assets.Model;
using Microsoft.EntityFrameworkCore;
using Transactions.Model;
using Users.Model.Admin;
using Users.Model.Client;
using Users.Model.Manager;

namespace Core.Infra
{
    public class InfoInvestDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; }
        public DbSet<Client> Clients { get; }
        public DbSet<Manager> Managers { get; }
        public DbSet<Admin> Admins { get; }
        public DbSet<Investment> Investments { get; }

        public InfoInvestDbContext(DbContextOptions<InfoInvestDbContext> options) : base(options)
        {
            Database.EnsureCreated();
            Investments = Set<Investment>();
            Assets = Set<Asset>();
            Clients = Set<Client>();
            Managers = Set<Manager>();
            Admins = Set<Admin>();
            CreateDefaultAdmin();
        }

        private void CreateDefaultAdmin()
        {
            var env = Environment.GetEnvironmentVariable("ADMIN_GUID_PASSWORD") ?? throw new Exception("Define admin guid password as a env var");
            var guid = Guid.Parse(env);
            Admins.Add(new Admin(guid, "Admin", DateTime.MinValue));
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfoInvestDbContext).Assembly);
        }
    }
}