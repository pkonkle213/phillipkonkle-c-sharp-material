using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string currentDir = Environment.CurrentDirectory;
            string fileLocation = currentDir + "\\Fizzbuzz.txt";
            bool shouldAppend = false;

            using (StreamWriter writer = new StreamWriter(fileLocation, shouldAppend))
            {
                for (int i = 1; i < 301; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        writer.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0 || i.ToString().Contains("5"))
                    {
                        writer.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0 || i.ToString().Contains("3"))
                    {
                        writer.WriteLine("Fizz");
                    }
                    else
                    {
                        writer.WriteLine(i);
                    }
                }
            }
        }
    }
}
