using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Represents a bug in the system.
    /// </summary>
    public class Bug
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
        /// The developer who summoned the bug into existence
        /// </summary>
        public string ResponsibleDev { get; set; } = "Matt Eland";

        /// <summary>
        /// The place in our code the bug exists (or likely exists)
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Whether or not the bug is currently unresolved
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// The text to display to the user
        /// </summary>
        public string DisplayText 
        { 
            get
            {
                // return Id + ") " + Summary + " (" + Created + ")";
                return $"{Id}) {Summary} ({Created})";
            } 
        }
    }
}
