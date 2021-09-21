using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
		static void Main(string[] args)
		{
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			string[] staffArray = new string[9];

			List<string> staff = new List<string>();

			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			staff.Add("Kevin"); // 0
			staff.Add("Matt");  // 1
			staff.Add("John");  // 2

			Console.WriteLine(staff.Count);

			List<int> ports = new List<int>();

			ports.Add(8080);
			ports.Add(1433);
			// ports.Add("Seattle"); - doesn't work since ports requires integers
			// ports.Add(3.14);

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow indexing");
			Console.WriteLine("####################");

			string nameOfKevin = staff[0];
			staff[1] = "Matt, but Microsoft asked him";

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			// Looping with a for loop
			for (int i=0; i < staff.Count; i++)
            {
				string staffMember = staff[i];

				Console.WriteLine(staffMember);
            }

			// Looping with a foreach
			foreach (string staffMember in staff) // IEnumerable
            {
				Console.WriteLine(staffMember);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			// Kevin, Matt..., John
			staff.Insert(1 /* Between Kevin and Matt */, "Rachelle");
			staff.Insert(4, "Fire Me!");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			staff.RemoveAt(4); // "Fire Me!"

			staff.Insert(0, "Doctor Doolittle"); // added to beginning of list
			staff.Remove("Doctor Doolittle");
			staff.Add("Steve"); // Added to the end of our list

			Console.WriteLine("####################");
			Console.WriteLine("Create a list using {} syntax");
			Console.WriteLine("####################");

			List<double> temperatures = new List<double> { 67.5, 80.1, 72.4 };
			List<string> cities = new List<string>() { "Miami", "Toledo", "Honolulu" };

			List<string> otherCities = new List<string> { "Chicago", "Columbus" };
			cities.AddRange(otherCities);

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			temperatures.Add(90.8);
			temperatures.Add(67.5);
			temperatures.Add(90.8);

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			if (staff.Contains("Steve"))
            {
				Console.WriteLine("Steve already works here");
            }
			else
            {
				staff.Add("Steve");
            }

			Random randomizer = new Random();
			int staffIndex = randomizer.Next(0, staff.Count);
			Console.WriteLine("The lucky staff member is ... " + staff[staffIndex]); // [0, 1, 2] 3

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int johnIndex = staff.IndexOf("John");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			double[] tempArray = temperatures.ToArray();

			Console.WriteLine("####################");
			Console.WriteLine("Arrays can be turned into lists");
			Console.WriteLine("####################");

			List<double> tempList = tempArray.ToList();

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			List<string> oldStaffList = staff.ToList();

			tempList.Sort();
			staff.Sort();

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			tempList.Reverse();
			staff.Reverse();


			// Quick Poll Goes here...


			Console.WriteLine("####################");
			Console.WriteLine("Finding the smallest number in a list");
			Console.WriteLine("####################");


			// temperatures.Sort(); // ascending - lowest up front
			double coldest = temperatures[0];
			double hottest = temperatures[0];

			foreach (double temp in temperatures)
            {
				if (temp < coldest)
                {
					coldest = temp;
                }

				if (temp > hottest)
                {
					hottest = temp;
                }
            }


			Console.WriteLine("####################");
			Console.WriteLine("Copying and filtering to another list");
			Console.WriteLine("####################");

			List<string> citiesNotEndingInO = new List<string>();

            foreach (string city in cities)
            {
				string c = city.ToLower();
				if (!c.EndsWith("o"))
                {
					citiesNotEndingInO.Add(city);
                }
            }

			Console.WriteLine("####################");
			Console.WriteLine("Transforming a list to another list");
			Console.WriteLine("####################");

			List<int> nameLength = new List<int>();

			foreach (string member in staff)
            {
				nameLength.Add(member.Length);
            }


			Console.WriteLine("####  BREAKOUT #####");
			Console.WriteLine("Create a list of strings, then use that list to generate " +
							  "a list of integers containing the first and last letter of the string");
			Console.WriteLine("#### /BREAKOUT #####");

			// ["Hello", "World"] -> ["Ho", "Wd"]

			List<string> words = new List<string> { "Zaphod", "Trillian", "Arthur", "Ford" };
			List<string> newWords = new List<string>();

			foreach (string word in words)
            {
				string newWord = word.Substring(0, 1) + word.Substring(word.Length - 1, 1);
				newWords.Add(newWord);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Modifying lists while looping over them is bad");
			Console.WriteLine("####################");
			Console.WriteLine();

			List<string> citiesToRemove = new List<string>();
			foreach (string city in cities)
            {
				if (city.ToLower().EndsWith("o"))
                {
					// This will cause an error: cities.Remove(city);
					citiesToRemove.Add(city);
                }
            }

			foreach (string city in citiesToRemove)
            {
				cities.Remove(city);
            }

			// cities.RemoveAll(citiesToRemove);

			Console.WriteLine("####################");
			Console.WriteLine("       STACKS");
			Console.WriteLine("####################");
			Console.WriteLine();

			Stack<string> urgentTasks = new Stack<string>();
			urgentTasks.Push("Teach Lecture");
			urgentTasks.Push("Talk to HR");
			urgentTasks.Push("Fix your mic");
			string fixMicTask = urgentTasks.Pop();
			urgentTasks.Pop();
			urgentTasks.Pop();

			// urgentTasks.Pop();

			Console.WriteLine("####################");
			Console.WriteLine("       QUEUES");
			Console.WriteLine("####################");
			Console.WriteLine();

			Queue<string> studentsNeedingHelp = new Queue<string>();
			studentsNeedingHelp.Enqueue("Vinny");
			studentsNeedingHelp.Enqueue("Matt");
			studentsNeedingHelp.Enqueue("John");

			while (studentsNeedingHelp.Count > 0)
			{
				string nextInLine = studentsNeedingHelp.Dequeue();
				Console.WriteLine("Now helping " + nextInLine);
			}

			Console.WriteLine("Done helping students");

			// Switch Statement
			string language = "C#";

			if (language == "C#")
            {
				Console.WriteLine("Yay C#");
            }
			else if (language == "VB .NET")
            {
				Console.WriteLine("VB is okay, I guess");
			}
			else if (language == "F#")
            {
				Console.WriteLine("F# is cool, but good luck getting a job with it");
			}
			else
            {
				Console.WriteLine("That's a language too");
			}

			switch (language)
            {
				case "C#":
					Console.WriteLine("Yay C#");
					break;

				case "VB .NET":
					Console.WriteLine("VB is okay, I guess");
					break;

				case "F#":
					Console.WriteLine("F# is cool, but good luck getting a job with it");
					break;

				default:
					Console.WriteLine("That's a language too");
					break;
            }
		}
	}
}
