using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main()
        {
            //
            // OLD MACDONALD
            //
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            // Let's try singing about a Farm Animal
            FarmAnimal animal = new Horse(); // This is Polymorphism
            Horse horse = (Horse)animal;
            horse.Gallup();
            //SingAbout(animal);

            /*
            FarmAnimal animal;
            Horse horse = new Horse();

            animal = horse; // Polymorphism happens here

            horse.Gallup();
            */

            // Can we swap out any animal in place here?
            animal = new Turkey();


            Tractor tractor = new Tractor();
            //SingAbout(tractor);

            // What about a few other animals?
            List<ISingable> farm = new List<ISingable>();
            farm.Add(horse);
            farm.Add(new Turkey());
            farm.Add(new Pterodactyl());
            farm.Add(tractor);
            farm.Add(new Instructor());

            Instructor steve = new Instructor();
            steve.Name = "COACH STEVE";
            farm.Add(steve);

            Instructor matt = new Instructor();
            matt.Name = "MATT";
            matt.Saying = "Microsoft didn't ask me";
            farm.Add(matt);

            foreach (ISingable thing in farm)
            {
                SingAbout(thing);
            }

            // What about tractors?

            //SingAbout(animal);
            ISingable mySingable = new Horse();
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