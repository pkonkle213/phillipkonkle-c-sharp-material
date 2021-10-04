using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Represents a bug in the system.
    /// </summary>
    public class Bug : TrackedItem
    {
        public Bug()
        {

        }

        public Bug(string summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// The developer who summoned the bug into existence
        /// </summary>
        public string ResponsibleDev { get; set; } = "Matt Eland";

        /// <summary>
        /// The place in our code the bug exists (or likely exists)
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The text to display to the user
        /// </summary>
        public override string DisplayText 
        { 
            get
            {
                string statusText;
                if (IsOpen)
                {
                    statusText = "Open";
                }
                else
                {
                    statusText = "Closed";
                }

                return $"{Id}) {Summary} ({statusText})";
            } 
        }
    }
}
