﻿using Roulette.Core.Context;
using System;
using System.Threading.Tasks;

namespace Roulette.Core.Bet.Services
{
    public class BettingService
    {
        private RouletteDbContext _context;
        

        public BettingService(RouletteDbContext context)
        {
            _context = context;
        }

        public async Task<string> PlaceBet(Entities.Bet bet)
        {
            try
            {
                _context.Bets.Add(bet);
            }
            catch (Exception ex)
            {
                throw;
            }

            return "Bet placed successfully";
        }
    }
}
