using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses
{
    public class IntOperations
    {
        /// <summary>
        /// Returns true if number is odd, otherwise it should return false.
        /// </summary>
        /// <param name="number">The number to evaluate</param>
        /// <returns>True if number is odd, otherwise returns false.</returns>
        public bool IsOdd(int number)
        {
            int remainder = number % 2;
            return remainder == 1;
        }

        /// <summary>
        /// This checks to see if number1 evenly goes into number2.
        /// 
        /// For example, with an input of 7, 14 the method should return true since 14 is evenly divisible by 7.
        /// </summary>
        /// <param name="number1">The number to divide the second number by</param>
        /// <param name="number2">The number to be divided by the first number</param>
        /// <returns>True if number2 can be evenly divided by number1, otherwise false</returns>
        public bool AreNumbersDivisible(int number1, int number2)
        {
            if (number1 == 0)
            {
                return false;
            }

            int remainder = number2 % number1;
            return remainder == 0;
        }

        /// <summary>
        /// Multiplies two numbers together and returns the result, ensuring that it is never negative.
        /// </summary>
        /// <param name="number1">The first number to multiply</param>
        /// <param name="number2">The second number to multiply</param>
        /// <returns>The product of the two numbers, ensuring the product is never negative</returns>
        public int MultiplyAbsolute(int number1, int number2)
        {
            int product = number1 * number2;
            
            // Ensure the result is never negative
            if (product < 0)
            {
                product *= -1;
            }

            return product;
        }
    }
}
