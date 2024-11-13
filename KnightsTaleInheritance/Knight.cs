using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Knight : ChessPiece
    {
        public Knight(int row, int col) : base(row, col)
        {
            Name = "Knight";
        }
        // Overriding the CanMove method for Knight's unique movement pattern (L-shape)
        public override bool CanMove(int newRow, int newCol)
        {
            // Knight moves in an "L" shape: (2, 1) or (1, 2) steps
            int rowDiff = Math.Abs(CurrentRow - newRow);
            int colDiff = Math.Abs(CurrentCol - newCol);

            return (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);
        }
        public override void Move()
        {
            // Implement logic for Knight to move
            Console.WriteLine($"{Name} is moving from ({CurrentRow}, {CurrentCol})");
        }
    }
}
