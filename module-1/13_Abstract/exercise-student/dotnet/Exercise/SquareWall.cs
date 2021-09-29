using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class SquareWall : RectangleWall
    {
        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength, sideLength)
        {
            this.SideLength = sideLength;
        }

        public int SideLength { get; }
        public override string ToString()
        {
            return $"{Name} ({SideLength}x{SideLength}) square";
        }
    }
}
