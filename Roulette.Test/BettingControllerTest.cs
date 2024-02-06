using System.Threading.Tasks;
using Moq;
using Roulette.Api.Controllers;
using Roulette.Core.Betting;
using Roulette.Core.Betting.Enums;
using Roulette.Core.Betting.Services;
using Roulette.Core.Context;
using Xunit;

namespace Roulette.Test
{
    public class BettingControllerTest
    {
        [Fact]
        public async Task PlaceBetTest()
        {
            // Arrange
            var context = new Mock<RouletteDbContext>();

            var bettingService = new BettingService(context.Object);
            var controller = new BettingController(bettingService);
            var betType = BetType.Inside;
            var pick = "36";
            var betValue = 1500m;

            var bet = BetBuilder.BuildBet(betType, pick, betValue);

            // Act
            var result = await controller.PlaceBet(bet);

            //Assert
            Assert.Equal("", result);
        }
    }
}
