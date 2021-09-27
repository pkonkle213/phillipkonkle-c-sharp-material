using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal
    {       
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public virtual string MakeSoundOnce()
        {
            return "";
        }

        public string MakeSoundTwice()
        {
            return this.MakeSoundOnce() + " " + this.MakeSoundOnce();
        }
    }
}
