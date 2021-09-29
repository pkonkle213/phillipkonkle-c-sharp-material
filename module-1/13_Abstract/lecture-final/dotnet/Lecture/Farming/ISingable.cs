using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        // Anything that implements me MUST have these methods:
        string MakeSoundOnce();
        string MakeSoundTwice();

        // Property
        string Name { get; }
    }

    // Completely hypothetical class for teaching purposes only
    public class Singable
    {
        public string MakeSoundOnce()
        {
            return "";
        }

        public string MakeSoundTwice()
        {
            return "";
        }

        public string Name { get; }
    }
}
