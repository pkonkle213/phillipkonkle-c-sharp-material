using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class TriangleWall : Wall
    {
        public TriangleWall(string name, string color, int baseSize, int height) : base(name, color)
        {
            this.Base = baseSize;
            this.Height = height;
        }

        public int Base { get; }
        public int Height { get; }

        public override int GetArea()
        {
            return Base * Height / 2;
        }

        public override string ToString()
        {
            return $"{Name} ({Base}x{Height}) triangle";
        }
    }
}
