using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecChallenge
{
    public class Plateau
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Plateau(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool IsValidMove(int x, int y)
        {
            if (x > this.X || x < 1 || y > this.Y || y < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
