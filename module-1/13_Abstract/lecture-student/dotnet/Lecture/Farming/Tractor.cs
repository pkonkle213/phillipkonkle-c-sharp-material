using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : Object, ISingable
    {
        public string MakeSoundOnce()
        {
            return "VROOOOM";
        }

        public string MakeSoundTwice()
        {
            return "VROOOM VROOOOOOOOOOOOOOOOM";
        }

        public string Name
        {
            get
            {
                return "TRACTOR";
            }
        }
    }
}
