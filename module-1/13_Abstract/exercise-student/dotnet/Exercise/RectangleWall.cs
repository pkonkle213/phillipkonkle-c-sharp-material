﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class RectangleWall : Wall
    {
        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            this.Length = length;
            this.Height = height;
        }

        public int Length { get; }
        public int Height { get; }

        public override int GetArea()
        {
            return Length * Height;
        }

        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle";
        }
    }
}
