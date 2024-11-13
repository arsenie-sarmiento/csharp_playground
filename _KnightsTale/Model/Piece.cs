using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KnightsTaleGamePlay.Model
{
    public class Piece
    {
        public (int Row, int Column)[] Offset;
        public Position Initial { get; set; }
        public Position Current { get; set; }
        public Piece()
        {
            Initial = new Position(0, 0);
            Current = new Position(0, 0);
            SetMoves();
        }

        private void SetMoves()
        {
            Offset =
            [
            (1, 2),
            (1, -2),
            (-1, 2),
            (-1, -2),
            (2, 1),
            (2, -1),
            (-2, 1),
            (-2, -1)]
            ;
        }
    }
}
