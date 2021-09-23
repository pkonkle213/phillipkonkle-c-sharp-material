using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture
{
    public class Car
    {
        /* Example of a blank constructor.
         * Default values of the property are assigned
         * before how the constructor was called.
         * AKA - how it calls wins over default
         */

        public Car()
        {

        }

        public Car(string owner)
        {
            this.Owner = owner;
        }
        
        /* Matt recommends we put "this." in constructors
         * to see what we have avaiable
         */

        /* By making the following method private, it can only be called by
         * code within Car.cs. Code in Program.cs is unable to call it
         */

        private void Crash()
        {
            Console.WriteLine("The car has crashed!");
        }

        public string Owner { get; set; } = "No owner";
        /* A property on the class named owner
         * that stores a string and can be
         * set from outside the class.
         * The value can also be got from outside.
         * 
         * Every property will have a get, not all
         * properties will have set
         */

        public int MilesDriven { get; private set; }
        /* Here, "private set" ensures that MilesDriven can
         * only be set within this class
         */


        public int Drive(int miles)
        {
            //Increase the miles this car has driven
            MilesDriven += miles;

            // Return the total miles driven
            return MilesDriven;
        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
        
        public void Honk(string target)
        {
            /* This is an overloaded function. It gives
             * a different option of how to use the function.
             */
            Console.WriteLine(Owner + " honks at " + target);
        }

        public void Hone(Car target)
        {
            Console.WriteLine(Owner + " honks at " + target.Owner + "'s car.");
        }
    }
}
