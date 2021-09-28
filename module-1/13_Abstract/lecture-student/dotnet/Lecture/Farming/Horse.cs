using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        public Horse() : base("HORSE")
        {
        }

        public override string MakeSoundOnce()
        {
            return "NEIGH";
        }

        public void Gallup()
        {
            // TODO: Implement galloping.
        }
    }
}
