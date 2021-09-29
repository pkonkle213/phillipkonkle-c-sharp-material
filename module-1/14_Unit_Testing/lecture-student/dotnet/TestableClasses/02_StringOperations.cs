using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses
{
    public class StringOperations
    {
        /// <summary>
        /// Returns a capitalized version of the input string where the first character is
        /// capitalized and the rest are lowercase.
        /// </summary>
        /// <example>
        /// "PascalCased" becomes "Pascalcased"
        /// "tuna" becomes "Tuna"
        /// "WALRUS" becomes "Walrus"
        /// "Bruce Wayne" becomes "Bruce wayne"
        /// </example>
        /// <param name="input">The string to generate a new casing version of</param>
        /// <returns>The formatted string.</returns>
        public string MakeStandardCapitalizationString(string input)
        {
            string firstLetter = input.Substring(0, 1);
            string remainingLetters = input.Substring(1);

            return firstLetter.ToUpper() + remainingLetters.ToLower();
        }

        /// <summary>
        /// Gets an address string suitable for use on the city / state line of a United States postal address
        /// </summary>
        /// <param name="city">The city</param>
        /// <param name="state">The state</param>
        /// <returns>A formatted string indicating the city and state</returns>
        public string GetAddressString(string city, string state)
        {
            return city + ", " + state;
        }

        /// <summary>
        /// Returns the number of vowels found in the input string
        /// </summary>
        /// <param name="input">The string to count for vowels</param>
        /// <returns>The number of vowels found in the input string.</returns>
        public int CalculateNumberOfVowels(string input)
        {
            int vowels = 0;

            input = input.ToLower();

            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
            }

            return vowels;
        }
    }
}
