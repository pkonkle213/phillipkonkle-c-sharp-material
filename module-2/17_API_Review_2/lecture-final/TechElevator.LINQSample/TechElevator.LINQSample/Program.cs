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
                new Person(2, "Kevin", "Teos", 21), // I'm rounding down to drinking age to avoid a pure guess here
                new Person(3, "Vinny", "Sanfillipo", 21)
                {
                    KnowsJavaScript = false
                }
            };

            // Ordinarily, to sum the ages of our users, you'd need to do this:
            int totalAge = 0;
            foreach (Person p in people)
            {
                totalAge += p.Age;
            }

            // But we can also do it in one line with LINQ
            int totalAge2 = people.Sum(p => p.Age);

            // Other Mathematical Operations
            int oldestAge = people.Max(p => p.Age);
            int youngestAge = people.Min(p => p.Age);
            double averageAge = people.Average(p => p.Age);

            // Finding
            Person jevin = people.FirstOrDefault(p => p.Id == 2);
            Person john = people.FirstOrDefault(p => p.Id == 3);

            // Filtering
            IEnumerable<Person> jsTeachers = people.Where(p => p.KnowsJavaScript == true);

            // Transforming
            IEnumerable<string> staffNames = people.Select(p => p.FullName);
        }
    }
}
