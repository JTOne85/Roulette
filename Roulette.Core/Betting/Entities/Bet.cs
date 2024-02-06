using Roulette.Core.Betingt.Entities;
using Roulette.Core.Betting.Enums;
using System;

namespace Roulette.Core.Betting.Entities
{
    public class Bet
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public decimal Multiplier { get; set; }
        public BetType BetType { get; set; }
        public Pick Pick { get; set; }
    }
}
