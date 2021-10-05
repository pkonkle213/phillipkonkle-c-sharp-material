using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string path = Console.ReadLine();

            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string word = Console.ReadLine();

            //2.5. Ask the user for the search string
            Console.WriteLine("Should the search be case sensitive? (Y\\N)");
            string caseWord = Console.ReadLine();
            if (caseWord.ToLower() == "n")
            {
                word = word.ToLower();
            }

            //3. Open the file
            int numLine = 0;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    //4. Loop through each line in the file
                    while (!reader.EndOfStream)
                    {
                        numLine++;
                        string line = reader.ReadLine();
                        if(caseWord.ToLower() =="n")
                        {
                            line = line.ToLower();
                        }

                        //5. If the line contains the search string, print it out along with its line number
                        if (line.Contains(word))
                        {
                            Console.WriteLine($"{numLine}) {line}");
                        }
                    }
                }
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine("The file was not found at the given location.");
            }
            catch (UnauthorizedAccessException error)
            {
                Console.WriteLine("You can't go in there!");
            }
            catch (DirectoryNotFoundException error)
            {
                Console.WriteLine("The directory doesn't exist.");
            }
            catch (IOException error)
            {
                Console.WriteLine("Cannot work with this file.");
            }
        }
    }
}
