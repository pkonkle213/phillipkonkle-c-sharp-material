using System;

namespace StringsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstrate immutability
            DateTime dueDate = DateTime.Now;

            DateTime newDueDate = dueDate.AddDays(2);
            DateTime lectureStart = new DateTime(2021, 9, 20, 9, 0, 0);

            Console.WriteLine("The homework is due " + newDueDate.ToShortDateString());




            // String Tests
            string name = "Ada Lovelace"; // 12 characters

            // Strings are actually arrays of characters (char).
            char[] charName = { 'A', 'd', 'a' }; // ..

            // 0. Those characters can be accessed using [] notation. (but I advise you to use substring instead)
            char firstLetter = name[0]; // 'A'

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e
            string first = name.Substring(0, 1); // "A"
            string last = name.Substring(name.Length - 1, 1); // "e"?

            Console.WriteLine("First and Last Character: " + first + " " + last);


            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string firstName = name.Substring(0, 3); // "Ada Lovelace" -> "Ada"

            Console.WriteLine("First 3 characters: " + firstName);

            // 3. Now print out the last three characters
            // Output: ace
            string last3 = name.Substring(name.Length - 3, 3);

            Console.WriteLine("Last 3 characters: " + last3);


            // 4. What about the last word?
            // Output: Lovelace

            string lastWord = name.Substring(4); // No length means go all the way to the end

            Console.WriteLine("Last Word: " + lastWord);


            // 5. Does the string contain inside of it "Love"?
            // Output: true
            bool hasLove = name.Contains("Love");

            Console.WriteLine("Contains \"Love\" " + hasLove);

            // "Squirrel" 1 -> 3

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            // "Ada Lovelace"
            int index = -1; // -1 is we didn't find it
            for (int i = 0; i < name.Length - 3; i++) // "abcdefg" FOO
            {
                string sub = name.Substring(i, 4);

                if (sub.ToLower() == "lace")
                {
                    index = i;
                    break;
                }
            }

            int easyIndex = name.IndexOf("lace");

            Console.WriteLine("Index of \"lace\": " + index + ", " + easyIndex);


            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int firstA = name.IndexOf("a"); // Start from left, going right
            int lastA = name.LastIndexOf("a"); // Start from right, going left
            Console.WriteLine("First A " + firstA);
            Console.WriteLine("Last A " + lastA);


            int numAs = 0;
            for (int i = 0; i < name.Length; i++)
            {
                string letter = name.Substring(i, 1); // "A" "d" "a" " "

                //if (letter == "a" || letter == "A")
                if (letter.ToUpper() == "A") // "a" -> "A", "A" -> "A", "SqUIRReL!" -> "SQUIRREL!"
                {
                    numAs++;
                }
            }

            Console.WriteLine("Number of \"a's\": " + numAs);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            string countess = name.Replace("Ada", "Ada, Countess of Lovelace");
            name = countess;
            Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;
            Console.WriteLine("Name is currently " + name);

            name = " ";
            name = name.Trim(); // " " -> ""

            // 10. If name is equal to null or "", print out "All Done".
            // if (name == null || name == "")
            //if (string.IsNullOrEmpty(name))
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("That's all folks!");
            }

            int numTimesToRepeat = 3;
            string result = "";
            string word = "Morning";

            for (int i = 0; i < numTimesToRepeat; i++)
            {
                result += word;
            }
            Console.WriteLine(result);



            Console.ReadLine();
        }
    }
}