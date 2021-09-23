using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.CarExamples
{
    public class Car
    {
        // PROPERTIES
        public string Model { get; set; }
        public double Odometer { get; private set; } // Create a property named "Odometer"

        // METHODS
        public double Drive(double milesToDrive)
        {
            // Drive should add the miles to drive to the odometer and then return the
            // current odometer mileage

            this.Odometer = this.Odometer + milesToDrive;

            return milesToDrive;
        }

        public double Crash(double valueOfObjectCrashedInto)
        {
            Console.WriteLine("Oh no! Crash!");

            // This should return the amount of money insurance will reimburse
            // This is calculated as half of the value.

            double reimbursedAmount = valueOfObjectCrashedInto * 0.5;

            return reimbursedAmount;
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk");
        }
    }
}
