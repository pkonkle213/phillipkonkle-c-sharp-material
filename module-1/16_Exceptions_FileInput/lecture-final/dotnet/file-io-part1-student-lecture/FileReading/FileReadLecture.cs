using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileInputLecture.FileReading
{
    public class FileReadLecture
    {
        public void CensorAliceAndWonderland()
        {
            // Let's take a look at DirectoryInfo and Environment
            // string docsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string currentDir = Environment.CurrentDirectory;

            // Let's take a look at Path
            // string dirName = Path.GetDirectoryName(currentDir);
            DirectoryInfo info = new DirectoryInfo(currentDir);

            IEnumerable<FileInfo> files = info.EnumerateFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            FileInfo file2 = new FileInfo("C:\\SomeFile.txt");

            // Let's take a look at FileInfo
            string backslash = "Matt says \"Hey\"";

            // Next we're going to demonstrate working with reading files
            string alicePath = @"C:\Users\Student\Alice.txt"; // @ means treat \ as a normal backslash
            DisplayCensoredFileContents(alicePath);
        }

        private void DisplayCensoredFileContents(string filePath)
        {
            Console.WriteLine();
            Console.WriteLine($"Displaying the censored contents of {filePath}");

            // Feel free to tweak these to your enjoyment
            string wordToCensor = "Cat";
            string replacementWord = "Doggo";

            /* USING STATEMENTS
             * 
             * A using statement opens a resource and makes sure it is closed when
             * the scope completes - even if an Exception was encountered
             */

            /*
            using (int i = 42)
            {

            }
            */

            try
            {
                // Add a using statement that creates a StreamReader pointing at the correct file
                using (StreamReader reader = new StreamReader(filePath)) // IDisposable
                {
                    // While we haven't reached the end of the file...
                    while (!reader.EndOfStream)
                    {
                        // Read in the next line from the file
                        string line = reader.ReadLine();

                        //Console.WriteLine(line);

                        // If the line needs censoring,
                        if (line.Contains(wordToCensor))
                        {
                            // Censor the line as needed by replacing WordToCensor with CensoredText
                            line = line.Replace(wordToCensor, replacementWord);

                            // Print the censored line to the Console
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file was not found");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("The directory ain't there");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Cannot work with file: " + ex.Message);
            }


            Console.WriteLine("Done Censoring");

            // TODO: What happens if the file doesn't exist or we don't have permissions?

            // TODO: Can we handle generic exceptions and more specific exceptions in the same try / catch?
        }
    }
}
