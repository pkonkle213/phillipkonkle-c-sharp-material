using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp.Items
{
    public class Feature : TrackedItem
    {
        public Feature(string summary) : base(summary)
        {
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
