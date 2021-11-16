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
            int numBooks = books.Count(book => !book.IsFiction); // Reduce

            // TODO: Filter
            IEnumerable<Book> fictionBooks = books.Where(book => book.IsFiction); // Equivalent of Filter

            // TODO: Min
            decimal cheapestPrice = books.Min(book => book.Price); 

            // TODO: Max
            decimal largestPrice = books.Max(book => book.Price);
            Book favoriteBook = books.FirstOrDefault(book => book.Title == "Sphere"); // Find

            Console.WriteLine("The books matching your search are:");

            var allTitles = books.Select(book => book.Title);

            // TODO: Foreach / Select
            foreach (Book book in books) 
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine($"There are {numBooks} book(s) with the cheapest price being {cheapestPrice:C} and the most expesive being {largestPrice:C}");
        }
    }
}
