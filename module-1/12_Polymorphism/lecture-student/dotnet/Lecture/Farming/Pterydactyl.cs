using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pterydactyl:FarmAnimal
    {
        public Pterydactyl() : base("PTERYDACTYL")
        {
            
        }

        public override string MakeSoundOnce()
        {
            return "CA-CAW";
        }

        public bool IsFlying { get; private set; }

        public void Fly()
        {
            IsFlying = true;
        }

        public void Land()
        {
            IsFlying = false;
        }
    }
}
