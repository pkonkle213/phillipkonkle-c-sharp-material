﻿using BugTrackerConsoleApp.Items;
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

        public BugManager() : base()
        {
            
        }

        public void SquashBug(int id)
        {
            // Find Bug
            Bug bug = FindBug(id);

            // Close it if we found it
            if (bug != null)
            {
                bug.IsOpen = false;
            }
        }

        /// <summary>
        /// Finds a bug with a specified ID or returns null.
        /// </summary>
        /// <param name="id">The ID to look for</param>
        /// <returns>The first matching bug, or null</returns>
        public Bug FindBug(int id)
        {
            foreach (Bug bug in bugs)
            {
                // If this is the bug we want, leave now
                if (bug.Id == id)
                {
                    return bug;
                }
            }

            // We didn't find a bug with that ID
            return null;
        }

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
