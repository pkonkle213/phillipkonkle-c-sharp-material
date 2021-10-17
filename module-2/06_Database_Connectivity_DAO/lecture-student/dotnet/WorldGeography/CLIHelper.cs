using System;

namespace WorldGeography
{
    public static class CLIHelper
    {
        public static int GetInteger(string message)
        {
            string userInput;
            int intValue;
            bool isFirstAttempt = true;

            do
            {
                if (!isFirstAttempt)
                {
                    Console.WriteLine("Invalid input format. Please try again");
                }

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                isFirstAttempt = false;
            }
            while (!int.TryParse(userInput, out intValue));

            return intValue;
        }

        public static double GetDouble(string message)
        {
            string userInput;
            double doubleValue;
            bool isFirstAttempt = true;

            do
            {
                if (!isFirstAttempt)
                {
                    Console.WriteLine("Invalid input format. Please try again");
                } 

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                isFirstAttempt = false;
            }
            while (!double.TryParse(userInput, out doubleValue));

            return doubleValue;
        }

        public static bool GetBool(string message)
        {
            string userInput;
            bool boolValue;
            bool isFirstAttempt = true;

            do
            {
                if (!isFirstAttempt)
                {
                    Console.WriteLine("Invalid input format. Please try again");
                }

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                isFirstAttempt = false;
            }
            while (!bool.TryParse(userInput, out boolValue));

            return boolValue;
        }

        public static string GetString(string message)
        {
            string userInput;
            bool isFirstAttempt = true;

            do
            {
                if (!isFirstAttempt)
                {
                    Console.WriteLine("Invalid input format. Please try again");
                }

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                isFirstAttempt = false;
            }
            while (string.IsNullOrEmpty(userInput));

            return userInput;
        }
    }
}
