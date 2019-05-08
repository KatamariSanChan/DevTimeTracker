using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.DatabaseObjects
{
    public class Activity
    {
        public int Id { get; private set; }
        public int RedmineKey { get; private set; }
        public string Description { get; private set; }

        public Activity()
        {

        }

        public Activity(int redmineKey, string description)
        {
            RedmineKey = redmineKey;
            Description = description;
        }
    }
}
