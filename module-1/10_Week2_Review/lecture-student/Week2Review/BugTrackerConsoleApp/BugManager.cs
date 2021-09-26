using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Responsible for tracking bugs
    /// </summary>
    public class BugManager
    {
        // Field or Class Variable. All fields are private
        private List<Bug> bugs = new List<Bug>();

        private int nextID = 1;

        /// <summary>
        /// Adds a new bug to the list
        /// </summary>
        /// <param name="newBug">The bug to add</param>
        public void AddBug(Bug newBug)
        {
            newBug.ID = nextID;
            nextID += 1;
            bugs.Add(newBug);
        }

        public Bug[] AllBugs
        {
            get
            {
                return bugs.ToArray();
            }
        }
    }
}
