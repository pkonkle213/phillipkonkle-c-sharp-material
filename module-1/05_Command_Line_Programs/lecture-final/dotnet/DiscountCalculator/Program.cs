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
            - [X] While Loops & Do While Loops
            - [X] Break & Continue
            - [X] Write vs WriteLine
            - [X] String Formatting
            - [X] Math Methods
            */

            Console.WriteLine("Welcome to the Discount Calculator");

            bool keepGoing = true;

            //do
            while (keepGoing)
            {
                // Prompt the user for a discount amount
                // The answer needs to be saved as a double
                Console.Write("Enter the discount amount (w/out percentage): ");

                string discountStr;
                discountStr = Console.ReadLine(); // "42"

                Console.WriteLine("You typed in " + discountStr);

                double discount;
                discount = double.Parse(discountStr); // "42" -> 42.0

                double result = discount * 2;
                Console.WriteLine("Twice that discount would be " + result);

                // Prompt the user for a series of prices
                Console.Write("Please provide a series of prices (space separated): ");

                string prices = Console.ReadLine(); // "10 5.99 12.99" ...

                string[] individualPrices = prices.Split(" "); // Look for spaces, and break into an array based on those spaces
                                                               // "10 5.99 12.99" -> ["10", "5.99", "12.99"]

                for (int index = 0; index < individualPrices.Length; index++)
                {
                    string priceStr = individualPrices[index];

                    decimal price = decimal.Parse(priceStr);

                    Console.Write("The original price is " + price.ToString("C2"));

                    decimal discounted = price * (1 - ((decimal)discount / 100M));

                    Console.Write(" and the discounted price is " + discounted.ToString("C2"));

                    decimal roundedUp = Math.Ceiling(discounted); // Round up to the nearest whole dollar
                    Console.WriteLine(" rounding up for charity / Canada would be " + roundedUp.ToString("C"));
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to go again? (Y/N)");
                string input = Console.ReadLine();

                if (input == "N" || input == "n")
                {
                    keepGoing = false;
                    // break; // Leave the loop immediately.
                } 
                else
                {
                    // continue; // Go immediately to the next loop
                }
            }
            //} while (keepGoing); // end of while loop

            Console.WriteLine("Thanks for discounting!");

            //Console.ReadLine(); // Wait for the user to type something
        } // When this method finishes, the program will end.
    }
}
