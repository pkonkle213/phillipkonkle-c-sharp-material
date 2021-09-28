using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            FarmAnimal animal = new Horse();
            Horse horse = (Horse)animal;

            Tractor tractor = new Tractor();

            // What about a few other animals?
            List<ISingable> farm = new List<ISingable>();
            farm.Add(horse);
            farm.Add(new Turkey());
            farm.Add(new Pterodactyl());
            farm.Add(tractor);

            Instructor steve = new Instructor();
            steve.Name = "COACH STEVE";
            steve.Saying = "\"Always call me 'coach'\"";
            farm.Add(steve);

            Instructor matt = new Instructor();
            matt.Name = "MATT";
            matt.Saying = "\"Microsoft didn't ask me (because I'm not a sociopath)\"";
            farm.Add(matt);

            Instructor brian = new Instructor();
            brian.Name = "BRIAN";
            brian.Saying = "\"Yeah... I'm not nice.\"";
            farm.Add(brian);

            Instructor john = new Instructor();
            john.Name = "JOHN";
            john.Saying = "\"This is the best way of doing it - except for all the others.\"";
            farm.Add(john);

            // Let's add cats!

            foreach (ISingable thing in farm)
            {
                SingAbout(thing);
            }
        }

        private static void SingAbout(ISingable thing)
        {
            string soundOnce = thing.MakeSoundOnce();
            string soundTwice = thing.MakeSoundTwice();

            Console.WriteLine($"And on his farm there was a {thing.Name} ee ay ee ay oh");
            Console.WriteLine($"With a {soundTwice} here and a {soundTwice} there");
            Console.WriteLine($"Here a {soundOnce}, there a {soundOnce} everywhere a {soundTwice}");
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();
        }

        /*
        private static void SingAbout(Tractor animal)
        {
            string soundOnce = animal.MakeSoundOnce();
            string soundTwice = animal.MakeSoundTwice();

            Console.WriteLine($"And on his farm there was a {animal.Name} ee ay ee ay oh");
            Console.WriteLine($"With a {soundTwice} here and a {soundTwice} there");
            Console.WriteLine($"Here a {soundOnce}, there a {soundOnce} everywhere a {soundTwice}");
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();
        }
        */
    }
}