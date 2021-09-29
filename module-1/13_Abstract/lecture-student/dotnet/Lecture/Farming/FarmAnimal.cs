using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        // An abstract method can only exist in an
        // abstract class. This method will also 
        // require an override

        public abstract string MakeSoundOnce();
        
        /*
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
