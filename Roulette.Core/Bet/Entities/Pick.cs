using Roulette.Core.Bet.Enums;
using System;

namespace Roulette.Core.Bet.Entities
{
    public class Pick
    {
        public Guid Id { get; set; }
        public BetType Type { get; set; }
        public PickDetails PickDetails { get; set; }
    }
}