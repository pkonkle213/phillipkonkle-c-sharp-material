using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BugTrackerConsoleApp.Items;

namespace BugTrackerConsoleApp
{
    public class BugFileManager
    {
        private const string filePath = @"C:\Users\Student\Bugs.csv";

        public void SaveBugs(BugManager bugs)
        {
            try
            {
                // Open some file on disk for writing
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    // Loop over all bugs
                    foreach (Bug bug in bugs.AllBugs)
                    {
                        // For each bug, write out a comma separated value version of it to the file
                        // Data is formatted like: ID,Summary,Responsible Dev,Location,Created Date,Is Open
                        writer.WriteLine($"{bug.Id},{bug.Summary},{bug.ResponsibleDev},{bug.Location},{bug.Created},{bug.IsOpen}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("There was a problem saving the bugs file. Not all changes may be saved.");
                Console.WriteLine(ex.Message);
            }
        }

        public void LoadBugs(BugManager bugs)
        {
            // Open some file on disk for reading

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Data is formatted like: ID,Summary,Responsible Dev,Location,Created Date,Is Open
                        string[] parts = line.Split(",");

                        // For each line, build a new Bug and set its properties
                        Bug bug = new Bug();
                        bug.Id = Convert.ToInt32(parts[0]);
                        bug.Summary = parts[1];
                        bug.ResponsibleDev = parts[2];
                        bug.Location = parts[3];
                        bug.Created = Convert.ToDateTime(parts[4]);
                        bug.IsOpen = Convert.ToBoolean(parts[5]);

                        // Add each bug to a BugManager
                        bugs.AddBug(bug);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The data file is not in the correct format: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file " + filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Problem reading from " + filePath);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
