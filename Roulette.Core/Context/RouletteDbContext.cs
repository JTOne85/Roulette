using Microsoft.EntityFrameworkCore;


namespace Roulette.Core.Context
{
    public class RouletteDbContext : DbContext
    {
        public DbSet<Betting.Entities.Bet> Bets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=roulette.db");
        }
    }
}
