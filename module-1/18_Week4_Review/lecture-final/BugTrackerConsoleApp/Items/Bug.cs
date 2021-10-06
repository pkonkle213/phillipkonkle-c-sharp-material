using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp.Items
{
    /// <summary>
    /// Represents a bug in the system.
    /// </summary>
    public class Bug : TrackedItem
    {
        public Bug() : base("Unnamed Bug")
        {

        }

        public Bug(string summary) : base(summary)
        {
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
                string statusText = IsOpen 
                    ? "Open"     // Value if IsOpen is true
                    : "Closed";  // Value if IsOpen is false

                return $"{Id}) {Summary} ({statusText})";
            }
        }
    }
}
