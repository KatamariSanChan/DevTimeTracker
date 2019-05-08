using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.DatabaseObjects
{
    public class TimeEntry
    {
        public int Id { get; private set; }
        public int RedmineKey { get; private set; }
        public int IssueId { get; set; }
        public DateTime SpentOn { get; private set; }
        public double Hours { get; set; }
        public int ActivityId { get; set; }
        public string Comments { get; set; }
    }
}
