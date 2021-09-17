using System;

namespace DiscountCalculator
{
    /// <summary>
    /// The Program class is run when the application starts.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args">Command line arguments that might get passed in to our program</param>
        public static void Main(string[] args)
        {
            /* Future Matt, please make sure we discuss the following things:
            - [ ] While Loops & Do While Loops
            - [ ] Break & Continue
            - [ ] Write vs WriteLine
            - [ ] String Formatting
            - [ ] Math Methods
            */

            Console.WriteLine("Welcome to the Discount Calculator");

            while (true)
            {



                // Prompt the user for a discount amount
                // The answer needs to be saved as a double
                Console.Write("Enter the discount amount (w/out percentage): ");
                string discountStr;
                discountStr = Console.ReadLine();

                double discount;
                discount = double.Parse(discountStr);
                double result = discount * 2;

                Console.WriteLine("Twice that discount would be " + result);

                // Prompt the user for a series of prices
                Console.Write("Please provide a series of prices (space separated): ");
                string pricesStr = Console.ReadLine();

                string[] individualPrices = pricesStr.Split(" "); // Breaks the string into an array based on " "

                for (int index = 0; index < individualPrices.Length; index++)
                {
                    string priceStr = individualPrices[index];

                    decimal price = decimal.Parse(priceStr);

                    Console.Write("The original price is " + price.ToString("C"));

                    decimal discounted = price * (1 - (decimal)(discount) / 100M);

                    Console.WriteLine(" and the discounted price is " + discounted.ToString("C"));
                }
            }
            Console.ReadLine();
        } // When this method finishes, the program will end.
    }
}
