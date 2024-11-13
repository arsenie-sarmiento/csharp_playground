using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTaleGamePlay.Model
{
    public class Position
    {
        public bool LegalNextMove { get; set; }
        // Row-Column may or may be selected
        public bool IsHurdle { get; set; }

        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public Position(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
            //CellCharacter = (char)CellType.Default;
        }
    }
}
