using Microsoft.EntityFrameworkCore;
using Roulette.Core.Context;
using Roulette.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.Core.Services
{
    public class PlayerService
    {
        private RouletteDbContext _context;
        public PlayerService(RouletteDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            try
            {
                return await _context.Players.ToListAsync();
            }
            catch (Exception ex) 
            {
                return null;

            }
        }
    }
}
