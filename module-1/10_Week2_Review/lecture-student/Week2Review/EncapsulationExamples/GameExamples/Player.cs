using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.GameExamples
{
    public class Player
    {
        // Properties
        public string Name { get; } // Can ONLY be set in the constructor
        public int Health { get; private set; }
        public int ExperiencePoints { get; private set; }

        // Derived Property
        public bool IsDead
        {
            get
            {
                if (this.Health <= 0)
                {
                    return true;
                }

                return false;
            }
        }

        // Constructor
        public Player(string name)
        {
            Console.WriteLine("Player Constructor Called");

            this.Health = 100;
            this.Name = name; // Make sure the casing is correct here
        }

        // Methods
        public int TakeDamage(int damageAmount)
        {
            /*
            this.Health -= damageAmount;
            Console.WriteLine("Health is now " + this.Health);

            return this.Health;
            */
            return ModifyHealth(-damageAmount);
        }

        public int Heal(int amountToHeal)
        {
            /*
            this.Health += amountToHeal;
            Console.WriteLine("Health is now " + this.Health);

            return this.Health;
            */
            return ModifyHealth(amountToHeal);
        }

        private int ModifyHealth(int amountToChange)
        {
            this.Health += amountToChange;
            Console.WriteLine("Health is now " + this.Health);

            return this.Health;
        }
    }
}
