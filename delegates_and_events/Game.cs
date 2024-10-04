using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Game
    {
        public readonly int Size;
        public int MoveCount = 0;

        public Cell[,] TheGrid;
        public readonly Cell GoalPosition;
        public readonly Cell CurrentPosition;

        public delegate void GoalReachedHandler(int movecount);
        public event GoalReachedHandler GoalReached;

        public Game(int size)
        {
            Size = size;
            GoalPosition = new Cell(Size - 1, Size - 1);
            InitializeCells();
        }

        private void InitializeCells()
        {
            TheGrid = new Cell[Size, Size];

            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    TheGrid[row, col] = new Cell(row, col);
                }
            }
        }

        internal async Task ChangePosition(int row, int col)
        {
            MoveCount += 1;
            // Validate indices
            if (row < 0 || row >= Size || col < 0 || col >= Size)
            {
                Console.WriteLine("Invalid move. Out of bounds.");
                return;
            }

            Cell current = TheGrid[row, col];
            Console.WriteLine($"Player moves to row: {row} col: {col}");

            // Simulate some delay
            await Task.Delay(1000);

            if (current.RowNumber == GoalPosition.RowNumber && current.ColumnNumber == GoalPosition.ColumnNumber)
            {
                GoalReached.Invoke(MoveCount);
            }
        }

        public async Task Start()
        {
            await ChangePosition(1, 2);
            await ChangePosition(3, 3);
            await ChangePosition(4, 1);
            await ChangePosition(2, 3);
            await ChangePosition(4, 4);
        }
    }
}
