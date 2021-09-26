using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Represents a bug in the system
    /// </summary>
    public class Bug
    {
        /// <summary>
        /// The unique identifier for the bug
        /// </summary>
        public int ID { get; set; }
        
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
        /// The place in our code the bug likely exists
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Whether or not the bug is currently resolved
        /// </summary>
        public bool IsOpen { get; private set; }

        public string DisplayText
        {
            get
            {
                //return ID + ") " + Summary + " (" + Created + ")";
                return $"{ID}- {Summary} ({Created})"; // Interpolation
            }
        }
    }
}
