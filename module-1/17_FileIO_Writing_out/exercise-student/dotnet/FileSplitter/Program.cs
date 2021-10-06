using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where is the input file (please include the path to the file)? ");
            string fileLocation = Console.ReadLine();

            Console.Write("How many lines of text (max) should there be in the split files? ");
            string linesOfSplitStr = Console.ReadLine();
            int linesOfSplit = int.Parse(linesOfSplitStr);

            int linesOfText = 0;
            using (StreamReader reader = new StreamReader(fileLocation))
            {
                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    linesOfText++;
                }
            }

            Console.WriteLine($"The input file has {linesOfText} lines of text.");
            Console.WriteLine();
            Console.WriteLine("Each file that is created must have a sequential number assigned to it.");
            Console.WriteLine();
            Console.WriteLine($"For a {linesOfText} 50 line input file \"input.txt\", this produces {linesOfText / linesOfSplit} output files.");
            Console.WriteLine();
            Console.WriteLine("**GENERATING OUTPUT**");
            Console.WriteLine();

            using (StreamReader reader = new StreamReader(fileLocation))
            {
                while (!reader.EndOfStream)
                {
                    for (int fileNumber = 0; fileNumber < linesOfText / linesOfSplit + 1; fileNumber++)
                    {
                        Console.WriteLine($"Generating input-{fileNumber + 1}.txt");
                    }
                }
            }
        }
    }
}
