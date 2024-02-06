using Microsoft.EntityFrameworkCore;


namespace Roulette.Core.Context
{
    public class RouletteDbContext : DbContext
    {
        public DbSet<Bet.Entities.Bet> Bets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=roulette.db");
        }
    }
}
