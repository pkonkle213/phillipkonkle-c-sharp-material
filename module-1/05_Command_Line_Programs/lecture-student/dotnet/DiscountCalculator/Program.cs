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

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");

        } // When this method finishes, the program will end.
    }
}
