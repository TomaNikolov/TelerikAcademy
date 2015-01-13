using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.Row + b.Row, a.Col + b.Col);
        }

        public static bool operator ==(Position a, Position b)
        {
            if (a.Col == b.Col && a.Row == b.Row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Position a, Position b)
        {
            return !(a == b);
        }
    }
}