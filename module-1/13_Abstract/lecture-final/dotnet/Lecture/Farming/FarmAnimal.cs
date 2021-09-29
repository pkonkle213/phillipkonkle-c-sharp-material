using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    /// <remarks>
    /// Abstract means class cannot be created directly
    /// Abstract allows us to have abstract methods
    /// </remarks>
    public abstract class FarmAnimal : ISingable
    {
        protected FarmAnimal(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        // abstract MUST be overridden
        public abstract string MakeSoundOnce();

        /* virtual - MAY be overridden
        public virtual string MakeSoundOnce()
        {
            return "";
        }
        */

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
