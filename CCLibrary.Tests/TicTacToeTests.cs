using Xunit;

namespace CCLibrary.Tests
{
    public class TicTacToeTests
    {
        [Fact]
        public void Play_twice_in_same_position()
        {
            var game = new TicTacToe();
            var coordX = new CoordX(Coord.one);
            var coordY = new CoordY(Coord.one);
            game.Play(coordX, coordY);
            Assert.Throws<System.Exception>(() => game.Play(coordX, coordY));
        }


        [Fact]
        public void Player_has_won_horizontally()
        {
            var game = new TicTacToe();
            game.Play(new CoordX(Coord.one), new CoordY(Coord.one));
            game.Play(new CoordX(Coord.two), new CoordY(Coord.one));
            game.Play(new CoordX(Coord.one), new CoordY(Coord.two));
            game.Play(new CoordX(Coord.two), new CoordY(Coord.two));
            game.Play(new CoordX(Coord.one), new CoordY(Coord.three));

            

        }
    }
}
