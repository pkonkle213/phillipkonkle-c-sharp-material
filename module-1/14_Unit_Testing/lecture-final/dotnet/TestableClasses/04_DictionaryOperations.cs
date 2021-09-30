using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses
{
    public class DictionaryOperations
    {
        /// <summary>
        /// Given an array of words, returns a Dictionary of those words as keys with values of the length of each word.
        /// </summary>
        /// <example>
        /// GetWordLengths([".NET", "is", "awesome"]) → {".NET": 4, "is": 2, "awesome": 7}
        /// </example>
        /// <param name="words">The words to add to the dictionary</param>
        /// <returns>The dictionary containing unique words as keys and the length of each word as its value</returns>
        public Dictionary<string, int> GetWordLengths(string[] words)
        {
            Dictionary<string, int> wordLengths = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordLengths.Add(word, word.Length);
            }

            return wordLengths;
        }
    }
}
