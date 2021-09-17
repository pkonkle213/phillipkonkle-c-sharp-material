using System;

namespace StringsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstrate immutability
            DateTime dueDate = DateTime.Today;

            Console.WriteLine("The homework is due " + dueDate.ToShortDateString());




            // String Tests
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).

            // 0. Those characters can be accessed using [] notation. (but I advise you to use substring instead)

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            //Console.WriteLine("First and Last Character: ");


            // 2. How do we write code that prints out the first three characters
            // Output: Ada


            //Console.WriteLine("First 3 characters: ");

            // 3. Now print out the last three characters
            // Output: ace

            //Console.WriteLine("Last 3 characters: ");


            // 4. What about the last word?
            // Output: Lovelace


            //Console.WriteLine("Last Word: ");


            // 5. Does the string contain inside of it "Love"?
            // Output: true


            //Console.WriteLine("Contains \"Love\"");


            // 6. Where does the string "lace" show up in name?
            // Output: 8


            //Console.WriteLine("Index of \"lace\": ");


            // 7. How many 'a's OR 'A's are in name?
            // Output: 3


            //Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            //Console.WriteLine(name);

            // 9. Set name equal to null.

            // 10. If name is equal to null or "", print out "All Done".

            Console.ReadLine();
        }
    }
}