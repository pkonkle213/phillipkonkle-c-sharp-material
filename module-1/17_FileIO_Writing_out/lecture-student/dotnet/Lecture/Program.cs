using System;
using System.IO;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1 - Writing to a File
            string filename = @"C:\Users\Student\FileWrite.txt";
            bool shouldAppend = false;  // False will delete everything in the file and write as if it's new
                                        // True will add the information to the end of the file

            using (StreamWriter writer = new StreamWriter(filename, shouldAppend))
            {
                writer.WriteLine("Hello world");
                writer.Write("Our current cohort is ");
                writer.WriteLine(15);
                writer.WriteLine("Have a lovely rest of your day.");
            }

            // PART 2 - Reading and Writing

            //  Loop through the contents of Hamlet and display each line on the screen
            string currentDir = Environment.CurrentDirectory;
            string hamletPath = Path.Combine(currentDir, "hamlet.txt"); // Casing shouldn't matter for the file and folder names
            string outputPath = Path.Combine(currentDir, "kevin.txt");

            try
            {
                using (StreamReader reader = new StreamReader(hamletPath))
                {
                    using (StreamWriter writer = new StreamWriter(outputPath, false)) // Big O Notation shows that this is more efficient than opening the write file every form of the loop
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            line = line.Replace("BERNARDO", "KEVINO");
                            line = line.Replace("FRANCISCO", "MATTO");
                            line = line.Replace("HORATIO", "JOHNO");
                            line = line.Replace("MARCELLUS", "VINNICUS");

                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Could not butcher Hamlet: " + ex.Message);
            }

            //  Write out the modified contents of Hamlet to a separate file

            // PART 3 - Other Examples - Particularly #4 and #9

        }
    }
}
