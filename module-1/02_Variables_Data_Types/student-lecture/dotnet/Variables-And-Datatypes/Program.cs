using System;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello .NET!");

            Console.WriteLine();

            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4a. Create a variable called seasonsOfFirefly and set it to 1.
            */

            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            4b. Create a variable called mattHasGivenUpHopeOnSeason2 and set it to false.
            */

            bool mattHasGivenUpHopeOnSeason2 = false;
            Console.WriteLine(mattHasGivenUpHopeOnSeason2);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            double pi = 3.1416;
            Console.WriteLine(pi);

            /* Breakout */

            /*
            7. Create and set a variable that holds your name. Called myName
            */

            string myName = "Phillip Konkle";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            int buttonsOnMouse = 5;

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            double percentageBattery = .91;

            /* End Breakout */

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */

            int difference = 121 - 27;
            Console.WriteLine(difference);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */

            double addition = 12.3 + 32.1;
            Console.WriteLine(addition);

            /*
            12. Create a string that holds your full name.
            */

            string fullName = "Phillip" + " " + "Konkle";

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */

            string fullGreeting = "Hello, " + fullName;

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            fullGreeting = fullGreeting + " Esquire";
            Console.WriteLine(fullGreeting);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            fullGreeting += " Esquire";

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            string movieName = "Saw";
            movieName += 2;

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            movieName += 0;

            /*
            18. What is 4.4 divided by 2.2?
            */

            double answer1 = 4.4 / 2.2;
            Console.WriteLine(answer1);

            /*
            19. What is 5.4 divided by 2?
            */

            double answer2 = 5.4 / 2;
            Console.WriteLine(answer2);

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */

            int division1 = 5 / 2;

            /*
            21. What is 5.0 divided by 2?
            */

            double division2 = 5.0 / 2;

            /* Poll Time! */

            /* Breakout */

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */

            decimal balance = 1234.56M;

            /*
            23. If I divide 5 by 2, what's my remainder?
            */

            int remainder = 5 % 2;

            /* End Breakout */

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */

            long var1 = 3;
            long var2 = 1000000000;
            long answer24 = var1 * var2;
            Console.WriteLine(answer24);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */

            bool doneWithExercises = false;

            /*
            26. Now set doneWithExercise to true.
            */

            doneWithExercises = true;

            // The program will stop here and wait for the user to press enter.
            Console.ReadLine(); 
        }
    }
}
