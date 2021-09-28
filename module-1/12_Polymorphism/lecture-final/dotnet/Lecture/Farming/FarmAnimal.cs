using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable
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

        public override string ToString()
        {
            return "Hi, I'm a " + Name;
        }

        public virtual void Pet()
        {
            // Details on petting the animal go here
        }
    }
}
