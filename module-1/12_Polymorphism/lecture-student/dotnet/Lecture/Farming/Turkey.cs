using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Turkey : FarmAnimal
    {
        public Turkey() : base("TURKEY")
        {

        }

        public override string MakeSoundOnce()
        {
            return "gobble gobble";
        }

        public int NumFeathers { get; set; } = 42;
    }
}
