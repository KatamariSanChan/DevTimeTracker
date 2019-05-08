using DevTimeTracker.DatabaseObjects;
using System.Collections.Generic;
using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class IssueTests
    {
        private void WriteIssueDetails(Issue issue)
        {
            Console.Write(string.Format("{0},{1},{2},{3}", issue.Id, issue.RedmineKey, issue.Description, issue.IsOpen));
        }

        private Issue CreateTestIssue()
        {
            return new Issue(99999, "TEST ISSUE", true);
        }

        [TestMethod]
        public void SaveDeleteTestIssue()
        {
            DTTDatabaseContext context = new DTTDatabaseContext();
            Issue newIssue = CreateTestIssue();

            Issue addedIssue = context.Issues.Add(newIssue);
            context.SaveChanges();

            FetchAllIssues();

            context.Issues.Remove(addedIssue);
            context.SaveChanges();
        }

        [TestMethod]
        public void FetchAllIssues()
        {
            DTTDatabaseContext context = new DTTDatabaseContext();
            foreach (Issue i in context.Issues)
            {
                WriteIssueDetails(i);
            }
        }
    }
}
