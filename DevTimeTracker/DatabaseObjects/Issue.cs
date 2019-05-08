using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.DatabaseObjects
{
    public class Issue
    {
        public int Id { get; private set; }
        public int RedmineKey { get; private set; }
        public string Description { get; private set; }
        public bool IsOpen { get; private set; }

        public Issue(int redmineKey, string description, bool isOpen)
        {
            RedmineKey = redmineKey;
            Description = description;
            IsOpen = isOpen;
        }

        public Issue()
        {

        }
    }
}
