using Microsoft.EntityFrameworkCore;
using Roulette.Core.Entities;


namespace Roulette.Core.Context
{
    public class RouletteDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("@Data Source=roulette.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 1,
                Name = "Joe",
                Surname = "Blogs",
                Email = "joe.blogs@player.io",
                IsActive = true,
            });
        }
    }
}
