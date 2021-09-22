using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPart2Lecture
{
    public class LectureCode
    {
		public void Start()
		{
			// ----------------------------------------
			// HashSets
			// ----------------------------------------
			HashSetEmailListExamples();

			// ----------------------------------------
			// Dictionaries
			// ----------------------------------------
			DictionarySportsJerseyExample();

			// ----------------------------------------
			// Example Program: Count the number of times a coin flips heads or tails
			// ----------------------------------------
			DictionaryCoinFlipExample();

			// ----------------------------------------
			// Less Common Cases with Dictionaries
			// ----------------------------------------
			DictionaryItemPricesExample();

			// ----------------------------------------
			// Example Program: Check to see if a username and password match
			// ----------------------------------------
			UsernamePasswordExample();
		}


		private void HashSetEmailListExamples()
		{
			// Declaring a hash set for tracking E-Mail addresses

			// Adding to hash sets

			// Removing from hash sets

			// Checking if something is in a hash set

			// Looping over a hash set (you won't do this too much)
		}

		private void DictionarySportsJerseyExample()
		{
			// Declaring and initializing a Dictionary of Jersey numbers and sports players

			// Adding an item to a Dictionary

			// Retrieving an item from a Dictionary by its key

			// Updating an item in a Dictionary

			// Check to see if a key already exists

			// Remove an element from the Dictionary
		}


		private void DictionaryCoinFlipExample()
		{
			// Flip a coin some number of times
			Random random = new Random();
			List<bool> coinFlipsThatAreHeads = new List<bool>();

			const int timesToFlip = 10;

			for (int i = 0; i < timesToFlip; i++)
            {
				bool isHeads = (random.Next(0, 2) == 0); // Will be either 0 or 1

				coinFlipsThatAreHeads.Add(isHeads);
            }

			// Track the number of coin flips into a dictionary

		}

		private void DictionaryItemPricesExample()
		{
			// Declaring and initializing a Dictionary (one-line version)

			// Iterate through the keys and key-value pairs in the Dictionary (You will RARELY do this)
		}

		private void UsernamePasswordExample()
		{

		}
	}
}
