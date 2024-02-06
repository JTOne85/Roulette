using Roulette.Core.Betting.Entities;
using Roulette.Core.Betting.Enums;
using System;

namespace Roulette.Core.Betingt.Entities
{
    public class Pick
    {
        public Guid Id { get; set; }
        public BetType Type { get; set; }
        public PickDetails PickDetails { get; set; }
    }
}