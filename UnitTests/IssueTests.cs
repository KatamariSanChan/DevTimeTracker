using DevTimeTracker.DatabaseObjects;
using System.Collections.Generic;
using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class IssueTests
    {
        private void WriteIssueDetails(Issue issue)
        {
            Console.WriteLine(string.Format("{0},{1},{2},{3}", issue.Id, issue.RedmineKey, issue.Description, issue.IsOpen));
        }

        private Issue CreateTestIssue()
        {
            int key = DateTime.Now.Millisecond;
            return new Issue(key, "TEST ISSUE", true);
        }

        [TestMethod]
        public void SaveTestIssue()
        {
            DTTDatabaseContext context = new DTTDatabaseContext();

            // create and add new issues to DbSet
            Issue newIssue = CreateTestIssue();
            Issue addedIssue = context.Issues.Add(newIssue);
            context.SaveChanges();

            try
            {
                // reload DbSet and fetch newly added Issue
                DTTDatabaseContext contextNew = new DTTDatabaseContext();
                contextNew.Issues.Load();
                Issue refreshedIssue = contextNew.Issues.Find(addedIssue.Id);

                // make sure properties match
                Assert.AreEqual(addedIssue.Id, refreshedIssue.Id);
                Assert.AreEqual(addedIssue.RedmineKey, refreshedIssue.RedmineKey);
                Assert.AreEqual(addedIssue.Description, refreshedIssue.Description);
                Assert.AreEqual(addedIssue.IsOpen, refreshedIssue.IsOpen);
            }
            finally
            {
                // remove newly added issue
                context.Issues.Remove(addedIssue);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void WriteAllIssuesToConsole()
        {
            DTTDatabaseContext context = new DTTDatabaseContext();
            foreach (Issue i in context.Issues)
            {
                WriteIssueDetails(i);
            }
        }
    }
}
