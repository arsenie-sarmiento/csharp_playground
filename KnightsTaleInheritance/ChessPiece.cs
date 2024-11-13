using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    public abstract class ChessPiece
    {
        public string Name { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentCol { get; set; }

        public ChessPiece(int row, int col)
        {
            CurrentRow = row;
            CurrentCol = col;
        }

        // Non-virtual method: Can't be overridden
        public void DisplayPosition()
        {
            Console.WriteLine($"{Name} is at position ({CurrentRow}, {CurrentCol})");
        }

        // Virtual method: Can be overridden in derived classes
        public virtual bool CanMove(int newRow, int newCol)
        {
            // Default check for valid move (does not consider piece-specific logic)
            return Board.IsValidMove(newRow, newCol);
        }

        // Abstract method: Must be overridden in derived classes
        public abstract void Move();
    }
}