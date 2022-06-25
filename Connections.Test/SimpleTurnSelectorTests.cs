using Connections.Gameplay;
using Connections.Players;

namespace Connections.Test
{
    public class SimpleTurnSelectorTests
    {
        [Fact]
        public void WhenOneNextSelectsFirstPlayer()
        {
            // Arrange
            var players = new[] { new Player { Id = 1 }, new Player { Id = 2 } };
            var sut = new SimpleTurnSelector(players);

            // Act
            var selected = sut.Next();

            // Assert
            Assert.Equal(players[0], selected);
        }

        [Fact]
        public void WhenTwoNextSelectsSecondPlayer()
        {
            // Arrange
            var players = new[] { new Player { Id = 1 }, new Player { Id = 2 } };
            var sut = new SimpleTurnSelector(players);

            // Act
            sut.Next();
            var selected = sut.Next();

            // Assert
            Assert.Equal(players[1], selected);
        }

        [Fact]
        public void WhenThreeNextSelectsSecondPlayer()
        {
            // Arrange
            var players = new[] { new Player { Id = 1 }, new Player { Id = 2 } };
            var sut = new SimpleTurnSelector(players);

            // Act
            sut.Next();
            sut.Next();
            var selected = sut.Next();

            // Assert
            Assert.Equal(players[0], selected);
        }
    }
}