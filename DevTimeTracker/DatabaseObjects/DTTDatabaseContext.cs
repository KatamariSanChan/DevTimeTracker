using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.DatabaseObjects
{
    public class DTTDatabaseContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}
