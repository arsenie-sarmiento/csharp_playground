using System;
using System.Collections.Generic;

namespace KnightsTaleGamePlay
{
    public class ChessMaze<T>
    {
        private T[,] maze;
        internal int rows, columns;

        public ChessMaze(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            maze = new T[rows, columns];
        }

        public void AddElement(int row, int col, T element)
        {
            if (row < 0 || row >= rows || col < 0 || col >= columns)
                throw new ArgumentOutOfRangeException("Position is out of bounds.");

            maze[row, col] = element;
        }

        public T GetElement(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= columns)
                throw new ArgumentOutOfRangeException("Position is out of bounds.");

            return maze[row, col];
        }

        public void DisplayMaze()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Assuming T is a type of chess piece or a similar object
        public List<Tuple<int, int>> GetPossibleMoves(int row, int col, IChessPiece piece)
        {
            return piece.GetPossibleMoves(row, col, maze);
        }
    }

    public interface IChessPiece
    {
        List<Tuple<int, int>> GetPossibleMoves(int row, int col, object maze);
    }

    public class Knight : IChessPiece
    {
        public List<Tuple<int, int>> GetPossibleMoves(int row, int col, object maze)
        {
            var moves = new List<Tuple<int, int>>();
            int[] moveOffsets = new int[] { -2, -1, 1, 2 }; // possible knight offsets

            foreach (var x in moveOffsets)
            {
                foreach (var y in moveOffsets)
                {
                    if (Math.Abs(x) != Math.Abs(y)) // Knight moves in "L" shape
                    {
                        int newRow = row + x;
                        int newCol = col + y;
                        if (IsValidMove(newRow, newCol, (ChessMaze<object>)maze))
                            moves.Add(new Tuple<int, int>(newRow, newCol));
                    }
                }
            }

            return moves;
        }

        private bool IsValidMove(int row, int col, ChessMaze<object> maze)
        {
            // Check bounds
            //if (row >= 0 && row < maze.GetType().GetField("rows").GetValue(maze) &&
            //    col >= 0 && col < maze.GetType().GetField("columns").GetValue(maze))
            if (row >= 0 && row < maze.rows && col >= 0 && col < maze.columns)
                return true; // Placeholder: additional rules for valid moves can be added

            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a ChessMaze where each cell can hold any type of object (e.g., chess pieces)
            ChessMaze<IChessPiece> chessMaze = new ChessMaze<IChessPiece>(8, 8);

            Knight knight = new Knight();
            chessMaze.AddElement(4, 4, knight);

            chessMaze.DisplayMaze();

            // Get possible moves for the knight from position (4, 4)
            var possibleMoves = chessMaze.GetPossibleMoves(4, 4, knight);

            Console.WriteLine("Knight's possible moves:");
            foreach (var move in possibleMoves)
            {
                Console.WriteLine($"Row: {move.Item1}, Col: {move.Item2}");
            }
        }
    }

}
