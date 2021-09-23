using System;

namespace EncapsulationLecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First we drive a car");
            Console.WriteLine();
            Car mattsCar = new Car(); // Car mattsCar is an object. A specific instance of a class
            mattsCar.Honk();

            mattsCar.Owner = "Matt";
            Console.WriteLine("The car is owned by " + mattsCar.Owner);

            mattsCar.Drive(22);
            mattsCar.Drive(22);

            Console.WriteLine("Then we do other things");
            Console.WriteLine();

            Console.WriteLine("Hey Matt, don't forget to talk about static and overloading");
            Console.WriteLine();
        }
    }
}
