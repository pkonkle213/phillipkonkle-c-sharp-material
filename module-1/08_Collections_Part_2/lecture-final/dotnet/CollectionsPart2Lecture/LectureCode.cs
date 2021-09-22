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
			HashSet<string> emails = new HashSet<string>();
			//List<string> emails = new List<string>();

			// Adding to hash sets
			emails.Add("Kevin.Teos@TechElevator.com");
			emails.Add("Matt.Eland@TechElevator.com");
			emails.Add("Vinny@TechElevator.com");
			emails.Add("John@TechElevator.com");
			emails.Add("Rachelle@TechElevator.com");
			emails.Add("Kevin.Teos@TechElevator.com");
			emails.Add("John@TechElevator.com");

			// Removing from hash sets
			emails.Remove("Rachelle@TechElevator.com");
			emails.Remove("Rachelle@TechElevator.com");

			// Checking if something is in a hash set
			if (emails.Contains("Matt.Eland@TechElevator.com"))
            {
				Console.WriteLine("Matt is already subscribed");
            }

			// Looping over a hash set (you won't do this too much)
			foreach (string address in emails)
            {
				Console.WriteLine("Now spamming " + address);
            }
		}

		private void DictionarySportsJerseyExample()
		{
			// Declaring and initializing a Dictionary of Jersey numbers and sports players
			Dictionary<int, string> team = new Dictionary<int, string>();

			// Adding an item to a Dictionary
			team[99] = "Wayne Gretzky"; // Key is 99, Value is "Wayne Gretzky"
			team[42] = "Bruce Wayne";
			team[30] = "Mike Richter";
			team[2] = "Brian Leetch";
			team[66] = "Wayne Gretzky";
			team[42] = "Steve Yzerman";
			// Avoid this syntax: team.Add(42, "Warren Buffet");

			// Retrieving an item from a Dictionary by its key
			Console.WriteLine("Jersey 2 is " + team[2]);

			// Updating an item in a Dictionary
			team[42] = "Bob Sagat";

			// Check to see if a key already exists
			if (team.ContainsKey(20))
            {
				Console.WriteLine("Jersey 20 is " + team[20]);
            } 
			else
            {
				Console.WriteLine("There is no player with jersey # 20");
            }

			// Remove an element from the Dictionary
			team.Remove(42);
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
			Dictionary<bool, int> counts = new Dictionary<bool, int>();

			foreach (bool isHeads in coinFlipsThatAreHeads)
            {
				if (counts.ContainsKey(isHeads))
				{
					// This occurs when we get a repeated result
					counts[isHeads] += 1;
				}
				else
                {
					// This occurs when we see a flip result for the first time
					counts[isHeads] = 1;
                }
            }
		}

		private void DictionaryItemPricesExample()
		{
			// Declaring and initializing a Dictionary (one-line version)
			Dictionary<string, decimal> prices = new Dictionary<string, decimal>
			{
				{ "DRP-1000", 9.99M }, // Key: "DRP-1000, Value 9.99
				{ "MTD-1001", 12.99M },
				{ "LYS-8999", 5.55M },
			};

			prices["PCK-4200"] = 4.99M;

			// Iterate through the keys and key-value pairs in the Dictionary (You will RARELY do this)
			decimal sum = 0M;

			foreach (KeyValuePair<string, decimal> pair in prices)
            {
				sum += pair.Value;

				Console.WriteLine(pair.Key + " is priced at " + pair.Value.ToString("C"));
            }

			Console.WriteLine("The total price of all items is " + sum.ToString("C"));
		}

		private void UsernamePasswordExample()
		{
			Console.WriteLine();
			Console.WriteLine("Enter your username");
			string username = Console.ReadLine();
			//username = username.ToLower();

			Console.WriteLine("Enter your password");
			string password = Console.ReadLine();

			/*
			Dictionary<string, string> credentials = new Dictionary<string, string>();
			credentials["MELAND"] = "FuzzyBunny";
			credentials["KTEOS"] = "CoachSteve";
			credentials["JFULTON"] = "AuntMildred";

			if (credentials.ContainsKey(username))
            {
				string storedPassword = credentials[username];

				if (password == storedPassword)
                {
					Console.WriteLine("You're logged in!");
                }
				else
                {
					Console.WriteLine("Invalid username or password");
                }
            }
			else
            {
				Console.WriteLine("Invalid username or password");
            }
			*/

			bool isValid = IsUsernameAndPasswordValid(username, password);

			if (isValid)
            {
				Console.WriteLine("You are logged in");
            } 
			else
            {
				Console.WriteLine("Invalid username or password");
            }
		}

		public bool IsUsernameAndPasswordValid(string username, string password)
        {
			Dictionary<string, string> credentials = new Dictionary<string, string>();
			credentials["MELAND"] = "FuzzyBunny";
			credentials["KTEOS"] = "CoachSteve";
			credentials["JFULTON"] = "AuntMildred";

			username = username.ToUpper();


			if (credentials.ContainsKey(username))
            {
				if (credentials[username] == password)
                {
					return true;
                }
            }

			return false;

			// One-liner version. Note that if the first condition is false, the second won't be evaluated
			// return credentials.ContainsKey(username) && credentials[username] == password;
		}
	}
}
