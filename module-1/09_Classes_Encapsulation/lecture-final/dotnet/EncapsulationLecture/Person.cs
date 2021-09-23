using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture
{
    public class Person
    {
        public Person(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
