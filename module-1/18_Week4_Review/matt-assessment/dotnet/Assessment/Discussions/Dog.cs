using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Discussions
{
    public class Dog
    {
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
