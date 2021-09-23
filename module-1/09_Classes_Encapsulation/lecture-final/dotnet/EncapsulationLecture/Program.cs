using System;

namespace EncapsulationLecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First we drive a car");
            Console.WriteLine();

            Car mattsCar = new Car("Matt", "Civic");
            mattsCar.Honk();
            mattsCar.Drive(22);
            mattsCar.Drive(22);
            mattsCar.Honk("Microsoft");
            mattsCar.Honk("Apple");

            Car kevinsCar = new Car("Kevin");
            kevinsCar.Honk(mattsCar);
            kevinsCar.Honk("Aroooga", 5);
            kevinsCar.Drive(1042);
            Console.WriteLine(kevinsCar.BuildEstimate());
            kevinsCar.Drive(10000);
            Console.WriteLine(kevinsCar.BuildEstimate());

            //mattsCar.MilesDriven = -8;
            Car forSale = new Car();
            Car anotherCar = new Car();

            bool areCarsEqual = (forSale == anotherCar);

            Console.WriteLine("The car is owned by " + mattsCar.Owner);

            Console.WriteLine("Then we do other things");
            Console.WriteLine();

            Person janeDoe = new Person("Jane", "Doe");

            Console.WriteLine("Hello " + janeDoe.FullName);

            Console.WriteLine("Hey Matt, don't forget to talk about static and overloading");
            Console.WriteLine();
        }
    }
}
