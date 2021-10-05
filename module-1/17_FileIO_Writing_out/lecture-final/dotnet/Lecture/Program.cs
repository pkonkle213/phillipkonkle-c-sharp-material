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
            bool shouldAppend = false;

            using (StreamWriter writer = new StreamWriter(filename, shouldAppend))
            {
                writer.WriteLine("Hello world");
                writer.Write("Our current cohort is ");
                writer.WriteLine(15);
                writer.WriteLine("Have a nice day!");
            }

            /*
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);

                // Work with the file...
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose(); // Close the file
                }
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                // Working with the file
            }
            */

            // PART 2 - Reading and Writing

            //  Loop through the contents of Hamlet and display each line on the screen
            string currentDir = Environment.CurrentDirectory;
            string hamletPath = Path.Combine(currentDir, "Hamlet.txt");
            string outputPath = Path.Combine(currentDir, "Kevin.txt");

            try
            {
                using (StreamReader reader = new StreamReader(hamletPath))
                {
                    using (StreamWriter writer = new StreamWriter(outputPath, false))
                    {
                        // writer.AutoFlush = true;

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

            PerformanceDemo.SlowPerformance();
            PerformanceDemo.FastPerformance();

            //Console.Write("Press enter to finish");
            //Console.ReadLine();
        }
    }
}
