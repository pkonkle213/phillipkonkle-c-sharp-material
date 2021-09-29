using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pterodactyl : FarmAnimal
    {
        public Pterodactyl() : base("PTERODACTYL")
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

        public override string ToString()
        {
            return "Yo, I'm a pterodactly. Ca-caw";
        }
    }
}
