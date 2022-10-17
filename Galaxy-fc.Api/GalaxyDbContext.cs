using Galaxy_fc.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Galaxy_fc.Api
{
    public class GalaxyDbContext : DbContext
    {
        public DbSet<Donation> Donations => Set<Donation>();

        public string DbPath { get; }

        public GalaxyDbContext()
        {
            DbPath = Path.Join(AppContext.BaseDirectory, "Galaxy.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
