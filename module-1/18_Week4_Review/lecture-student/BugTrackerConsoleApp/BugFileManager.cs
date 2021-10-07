using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BugTrackerConsoleApp.Items;

namespace BugTrackerConsoleApp
{
    public class BugFileManager
    {
        public BugManager Manager { get; set; }
        public void LoadBugs()
        {
            // Open some file on disk for reading
            string filePath = @"C:\Users\Student\Bugs.csv";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        //It's important to document how file being read is formatted
                        //Data is formatted like: ID, Summary, Responsible Dev, Location, Created Date, Is Open
                        string[] parts = line.Split(",");

                        Bug bug = new Bug();
                        bug.Id = Convert.ToInt32(parts[0]);
                        bug.Summary = parts[1];
                        bug.ResponsibleDev = parts[2];
                        bug.Location = parts[3];
                        bug.Created = Convert.ToDateTime(parts[4]);
                        bug.IsOpen = Convert.ToBoolean(parts[5]);

                        //Add each bug to a BugManager
                        Manager.AddBug(bug);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Problem reading from " + filePath);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
