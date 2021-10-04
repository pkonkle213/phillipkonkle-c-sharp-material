using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    public abstract class TrackedItem
    {

        /// <summary>
        /// The unique identifier for the bug
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The details associated with the bug
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// The date and time the bug was created
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Now;

        /// <summary>
        /// Whether or not the bug is currently unresolved
        /// </summary>
        public bool IsOpen { get; set; } = true;

        public abstract string DisplayText { get; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
