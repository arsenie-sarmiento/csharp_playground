using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    internal class Board
    {
        public static int[,] MazeGrid = new int[,]
        {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 0, 1, 0 },
        { 0, 1, 0, 0, 0 },
        { 0, 0, 0, 1, 0 },
        { 0, 0, 0, 0, 0 } // Target position at (4, 4)
        };

        public static bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < MazeGrid.GetLength(0) && col >= 0 && col < MazeGrid.GetLength(1) && MazeGrid[row, col] == 0;
        }
    }
}

