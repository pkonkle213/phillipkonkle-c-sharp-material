using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses
{
    public class ArrayOperations
    {
        /// <summary>
        /// Returns true if all numbers in the numbers array are the same number
        /// </summary>
        /// <param name="numbers">The array to check</param>
        /// <returns>True if every element of numbers is identical, otherwise returns false</returns>
        public bool AreAllNumbersIdentical(int[] numbers)
        {
            int firstNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number != firstNumber)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns the last number in an array
        /// </summary>
        /// <param name="numbers">The array to check</param>
        /// <returns>The last number in the array</returns>
        public int GetLowestNumber(int[] numbers)
        {
            int lowest = 0;

            foreach (int number in numbers)
            {
                if (number < lowest)
                {
                    lowest = number;
                }
            }

            return lowest;
        }

        /// <summary>
        /// Takes in an array of numbers and returns a new array representing the same numbers in reversed order
        /// </summary>
        /// <param name="numbers">The numbers to reverse</param>
        /// <returns>A new array representing the input numbers, but in reverse order</returns>
        public int[] ReverseArray(int[] numbers)
        {
            List<int> list = new List<int>(numbers);

            list.Reverse();

            return list.ToArray();
        }
    }
}
