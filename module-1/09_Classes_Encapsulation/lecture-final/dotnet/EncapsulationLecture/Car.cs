using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture
{
    public class Car
    {
        // A parameterless constructor
        public Car()
        {
            this.Model = "Gremlin";
        }

        public Car(string owner)
        {
            this.Owner = owner;
            this.Model = "Gremlin";
        }

        public Car(string owner, string model)
        {
            this.Owner = owner;
            this.Model = model;
        }

        // Get-only property can only be set in the constructor
        public string Model { get; } 

        // A property on the class named Owner
        // That stores a string and can be
        // set from outside the class.
        // The value can also be got from outside.
        public string Owner { get; set; } = "No Owner";

        // Private set means that it can only be modified by
        // this class
        public int MilesDriven { get; private set; }

        public decimal EstimatedValue
        {
            get
            {
                decimal valuation = 20000M;

                valuation -= MilesDriven * 2.5M;

                return valuation;
            }
        }

        public string BuildEstimate()
        {
            return "The value of " + Owner + "'s " + Model + " is " + EstimatedValue.ToString("C");
        }

        private void Crash()
        {
            Console.WriteLine("The car has crashed!");
        }

        public int Drive(int miles)
        {
            // Increase the miles this car has driven
            MilesDriven = MilesDriven + miles;

            if (MilesDriven > 1000)
            {
                Crash();
            }

            // Return the total miles driven
            return MilesDriven;
        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

        public void Honk(string sound, int numTimes)
        {
            for (int i = 0; i < numTimes; i++)
            {
                Console.WriteLine(sound);
            }
        }

        public bool Honk(string target)
        {
            if (target == "Microsoft")
            {
                Console.WriteLine("Nobody honks at Microsoft");
                return false;
            }
            else
            {
                Console.WriteLine(Owner + " honks at " + target);
                return true;
            }
        }

        public void Honk(Car target)
        {
            Console.WriteLine(Owner + " honks at " + target.Owner + "'s car");
        }

        public void Honk(Car otherCar, bool isBroken)
        {

        }
    }
}
