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
        // Field or Class Variable
        private readonly List<Bug> bugs = new List<Bug>();

        private int nextId = 1;

        /// <summary>
        /// Adds a new bug
        /// </summary>
        /// <param name="newBug">The bug to add</param>
        public void AddBug(Bug newBug)
        {
            newBug.Id = nextId;

            nextId += 1;

            bugs.Add(newBug);
        }

        /// <summary>
        /// All of the current bugs
        /// </summary>
        public Bug[] AllBugs
        {
            get
            {
                return bugs.ToArray();
            }
        }
    }
}
