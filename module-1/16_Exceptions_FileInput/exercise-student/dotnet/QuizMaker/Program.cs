using System;
using System.IO;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            string path = Console.ReadLine();

            using (StreamReader reader = new StreamReader(path))
            {
                string quiz1 = reader.ReadLine();
                int symbol = quiz1.IndexOf("|");
                string question = quiz1.Substring(0, symbol);
                string nextOption = quiz1.Substring(symbol + 1);

                Console.WriteLine(question);
                int answer = 1;
                while (nextOption.Contains("|"))
                {
                    symbol = nextOption.IndexOf("|");
                    if (nextOption[symbol - 1] == '*')
                    {
                        Console.WriteLine(answer + ". " + nextOption.Substring(0, symbol-1));
                    }
                    else
                    {
                        Console.WriteLine(answer + ". " + nextOption.Substring(0, symbol));
                    }
                    answer++;
                    nextOption = nextOption.Substring(symbol + 1);
                }
                Console.WriteLine(answer + ". " + nextOption);
            }

        }
    }
}
