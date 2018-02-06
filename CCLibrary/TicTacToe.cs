using System;

namespace CCLibrary
{
    public enum Coord
    {
        one = 1,
        two = 2,
        three = 3
    }

    public enum Players
    {
        empty,
        X,
        O
    }


    public class TicTacToe
    {
        private TTTBoard tttBoard;
        public TicTacToe()
        {
            tttBoard = new TTTBoard();
        }

        public TTTPlay Play(CoordX cX, CoordY cY)
        {
            if (!tttBoard.IsXYFree(cX, cY))
                throw new System.Exception();

            tttBoard.SetPosition(cX, cY);

            return new TTTPlay();
        }
    }

    public class TTTPlay
    {

    }

    public class CoordX
    {
        private Coord _coordX;
        public CoordX(Coord coordX)
        {
            _coordX = coordX;
        }

        public int GetValue()
        {
            return (int)_coordX;
        }

    }
    public class CoordY
    {
        private Coord _coordY;
        public CoordY(Coord coordY)
        {
            _coordY = coordY;
        }

        public int GetValue()
        {
            return (int)_coordY;
        }
    }

    public class TTTBoard
    {
        private Players[,] values = new Players[3,3];
        private int playNumber;

        public TTTBoard()
        {
            playNumber = 0;
        }

        public bool IsXYFree(CoordX cX, CoordY cY)
        {
            return values[cX.GetValue(), cY.GetValue()] == Players.empty;
        }

        public void SetPosition(CoordX cX, CoordY cY)
        {
            if (playNumber % 2 == 1)
                values[cX.GetValue(), cY.GetValue()] = Players.X;

            if (playNumber % 2 == 0)
                values[cX.GetValue(), cY.GetValue()] = Players.O;

            playNumber += 1;
        }


        
    }


}
