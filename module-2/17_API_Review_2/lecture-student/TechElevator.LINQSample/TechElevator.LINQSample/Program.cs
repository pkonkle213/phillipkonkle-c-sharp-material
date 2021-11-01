using System;
using System.Collections.Generic;
using System.Linq; // This is needed for these methods

namespace TechElevator.LINQSample
{
    public class Program
    {
        public static void Main()
        {
            // Some Sample Data
            List<Person> people = new List<Person>
            {
                new Person(1, "Matt", "Eland", 41),
                new Person(2, "Kevin", "Teos", 21) // I'm rounding down to drinking age to avoid a pure guess here
            };

            // Ordinarily, to sum the ages of our users, you'd need to do this:
            int totalAge = 0;
            foreach (Person p in people)
            {
                totalAge += p.Age;
            }

            // But we can also do it in one line with LINQ

            // Other Mathematical Operations

            // Finding

            // Filtering

            // Transforming
        }
    }
}
