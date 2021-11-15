using System;
using System.Collections.Generic;
using System.Linq;

namespace MattEland.LinqSamples
{
    class Program
    {
        static void Main()
        {
            BookProvider dataProvider = new BookProvider();

            List<Book> books = dataProvider.Books.ToList();

            // TODO: Count
            int numBooks = 0;

            // TODO: Filter

            // TODO: Min
            decimal cheapestPrice = 0; 

            // TODO: Max
            decimal largestPrice = 0;

            Console.WriteLine("The books matching your search are:");

            // TODO: Foreach / Select
            foreach (Book book in books) 
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine($"There are {numBooks} book(s) with the cheapest price being {cheapestPrice:C} and the most expesive being {largestPrice:C}");
        }
    }
}
