using System;
using Roulette.Core.Betting.Enums;
using Roulette.Core.Betting.Entities;
using Roulette.Core.Betingt.Entities;

namespace Roulette.Core.Betting
{
    public static class BetBuilder
    {
        private static decimal GetMultiplierByPick(BetType betType)
        {
            if (betType == BetType.Inside) return 3.5m;
            else return 1m;
        }

        public static Betting.Entities.Bet BuildBet(BetType betType, string pick, decimal betValue)
        {
            switch (betType)
            {
                case BetType.Inside:
                    return BuildInsideBet(pick, betValue);
                //case BetType.Outside:
                //    return BuildOutsideBet(pick);
                default: return null;

            }
        }

        public static Entities.Bet BuildInsideBet(string pick, decimal betValue)
        {
            return new Entities.Bet
            {
                Id = Guid.NewGuid(),
                BetType = BetType.Inside,
                Multiplier = GetMultiplierByPick(BetType.Inside),
                Value = betValue,
                Pick = CreatePick(BetType.Inside, pick)
            };
        }

        private static Pick CreatePick(BetType betType, string pick)
        {
            return new Pick
            {
                Id = Guid.NewGuid(),
                Type = betType,
                PickDetails = CreatePickDetails(pick)
            };
        }

        private static PickDetails CreatePickDetails(string pick)
        {
            return new PickDetails
            {
                Id = Guid.NewGuid(),
                PickDescription = pick,
            };
        }
    }
}
