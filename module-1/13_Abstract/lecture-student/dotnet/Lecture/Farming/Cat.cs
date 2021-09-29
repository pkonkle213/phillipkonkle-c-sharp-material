using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Cat : FarmAnimal
    {
        public Cat() : base("CAT")
        {
        }

        public override string MakeSoundOnce()
        {
            return "MEOW";
        }
    }
}
