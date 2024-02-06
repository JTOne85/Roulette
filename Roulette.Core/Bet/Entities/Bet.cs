using Roulette.Core.Bet.Enums;
using System;

namespace Roulette.Core.Bet.Entities
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
