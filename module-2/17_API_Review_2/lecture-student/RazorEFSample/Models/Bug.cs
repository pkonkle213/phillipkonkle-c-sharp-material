using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorEFSample.Models
{
    /// <summary>
    /// Represents a bug in the system.
    /// </summary>
    public class Bug
    {
        public Bug()
        {

        }

        public Bug(string summary)
        {
            Summary = summary;
        }

        /// <summary>
        /// The unique identifier for the bug
        /// </summary>
        [Range(0, int.MaxValue)] // 0 is acceptable for a new bug
        public int Id { get; set; }

        /// <summary>
        /// The details associated with the bug
        /// </summary>
        [Required]
        public string Summary { get; set; }

        /// <summary>
        /// The date and time the bug was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Whether or not the bug is currently unresolved
        /// </summary>
        public bool IsOpen { get; set; } = true;

        /// <summary>
        /// The developer who summoned the bug into existence
        /// </summary>
        [StringLength(255)]
        public string ResponsibleDev { get; set; }

        /// <summary>
        /// The place in our code the bug exists (or likely exists)
        /// </summary>
        [StringLength(255)]
        public string Location { get; set; }
    }
}
