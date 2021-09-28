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
            FarmAnimal animal = new Horse();
            Horse horse = (Horse)animal;
            horse.Gallup();
            //SingAbout(animal);

            // Can we swap out any animal in place here?
            animal = new Turkey();


            // What about a few other animals?
            List<FarmAnimal> farm = new List<FarmAnimal>();
            farm.Add(horse);
            farm.Add(new Turkey());
            farm.Add(new Pterydactyl());

            // What about tractors?
            //SingAbout(animal);

            foreach (FarmAnimal thing in farm)
            {
                SingAbout(thing);
            }
        }

        private static void SingAbout(FarmAnimal animal)
        {
            string soundOnce = animal.MakeSoundOnce();
            string soundTwice = animal.MakeSoundTwice();

            Console.WriteLine($"And on his farm there was a {animal.Name} ee ay ee ay oh");
            Console.WriteLine($"With a {soundTwice} here and a {soundTwice} there");
            Console.WriteLine($"Here a {soundOnce}, there a {soundOnce} everywhere a {soundTwice}");
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();
        }
    }
}