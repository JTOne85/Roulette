using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using Roulette.Api.Controllers;
using Roulette.Core.Context;
using Roulette.Core.Entities;
using Roulette.Core.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace Roulette.Test
{
    public class PlayerControllerTest
    {

        


        [Fact]
        public async void GetAllPlayers()
        {
            // Arrange

            var mockContext = new Mock<RouletteDbContext>();
            mockContext.Setup<DbSet<Player>>(p => p.Players).ReturnsDbSet(GetMockPlayers());

            var playerService = new PlayerService(mockContext.Object);
            var controller = new PlayerController(playerService);
            
            
            // Act
            var result = await controller.GetAllPlayers();
            

            // Assert
        }

        // given a player with an id of 1 exists
        // when I retrieve the player by the id
        // then I should get the player with the given id back as an object

        private IEnumerable<Player> GetMockPlayers()
        {
            return new List<Player>()
            {
                new Player{
                    Id = 900,
                    Name = "Joe",
                    Surname = "Blogs",
                    Email = "joe.blogs@playersinc.io",
                    IsActive = true,
                },
                new Player{
                    Id = 901,
                    Name = "Jane",
                    Surname = "Doe",
                    Email = "jane.doe@playersinc.io",
                    IsActive = true,
                },
                new Player{
                    Id = 899,
                    Name = "Katniss",
                    Surname = "Everdeen",
                    Email = "katnis.everdeen@playersinc.io",
                    IsActive = false
                }
            };
        }
    }
}