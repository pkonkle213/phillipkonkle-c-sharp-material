using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Instructor : ISingable
    {
        public Instructor()
        {

        }

        // FIELD - private
        private string saying = "I'm allegedly not a sociopath";

        // OLD-SCHOOL PROPERTY
        public string Saying
        {
            get
            {
                return this.saying; // LOWERCASE
            }
            set
            {
                // value is the thing we're setting it = to
                this.saying = value;
            }
        }

        // AUTOMATIC PROPERTY - public
        // may have a private / protected set
        public string Name { get; set; } = "AN INSTRUCTOR";

        public string MakeSoundOnce()
        {
            return "ANY QUESTIONS?";
        }

        public string MakeSoundTwice()
        {
            return Saying;
        }
    }
}
