using Roulette.Core.Bet.Enums;
using System;

using Roulette.Core.Bet.Entities;

namespace Roulette.Core.Bet
{
    public static class BetBuilder
    {
        private static decimal GetMultiplierByPick(BetType betType)
        {
            if (betType == BetType.Inside) return 3.5m;
            else return 1m;
        }

        public static Entities.Bet BuildBet(BetType betType, string pick, decimal betValue)
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

        //public static Entities.Bet BuildOutsideBet(string pick)
        //{
        //    return new Entities.Bet();
        //}

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
