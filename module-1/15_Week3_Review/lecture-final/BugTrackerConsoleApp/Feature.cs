using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    public class Feature : TrackedItem
    {
        public Feature(string summary)
        {
            this.Summary = summary;
        }

        public double HoursEstimated { get; set; }
        public double HoursActual { get; set; }

        public override string DisplayText
        {
            get
            {
                return $"{Id}) {Summary} (Feature)";
            }
        }
    }
}
