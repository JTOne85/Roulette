﻿using Microsoft.AspNetCore.Mvc;
using Roulette.Core.Betting.Entities;
using Roulette.Core.Betting.Services;
using System.Threading.Tasks;

namespace Roulette.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BettingController : ControllerBase
    {

        private BettingService _bettingService;

        public BettingController(BettingService bettingService)
        {
            _bettingService = bettingService;
        }

        [HttpPost]
        public async Task<string> PlaceBet([FromBody] Bet bet)
        {
            var result = await _bettingService.PlaceBet(bet);
            return result;
        }
    }
}
