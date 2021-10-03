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

            // Let's take a look at Path

            // Let's take a look at FileInfo

            // Next we're going to demonstrate working with reading files
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

            // Add a using statement that creates a StreamReader pointing at the correct file
            {
                // While we haven't reached the end of the file...
                {
                    // Read in the next line from the file

                    // If the line needs censoring,
                    {
                        // Censor the line as needed by replacing WordToCensor with CensoredText

                        // Print the censored line to the Console
                    }
                }

            }


            Console.WriteLine("Done Censoring");

            // TODO: What happens if the file doesn't exist or we don't have permissions?

            // TODO: Can we handle generic exceptions and more specific exceptions in the same try / catch?
        }
    }
}
