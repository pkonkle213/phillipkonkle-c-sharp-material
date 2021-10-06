using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Discussions
{
    public class ParametersDiscussion
    {
        public void LaunchPad()
        {
            Dog dog = new Dog("Jester", 4);
            int favoriteNumber = 42;

            ModifyDog(dog);
            ModifyNumber(favoriteNumber);

            Console.WriteLine($"{dog.Name} is {dog.Age}");
            Console.WriteLine($"My favorite number is {favoriteNumber}");
        }

        private void ModifyDog(Dog dog)
        {
            dog.Age += 1; // dog.Age++ works too
            Console.WriteLine($"Happy birthday, {dog.Name} is now {dog.Age}");
        }

        private void ModifyNumber(int number)
        {
            number = 12345;
            Console.WriteLine($"ModifyNumber's number is {number}");
        }
    }
}
