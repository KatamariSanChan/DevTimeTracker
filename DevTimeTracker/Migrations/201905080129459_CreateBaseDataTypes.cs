namespace DevTimeTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBaseDataTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RedmineKey = c.Int(nullable: false),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RedmineKey = c.Int(nullable: false),
                        Description = c.String(maxLength: 4000),
                        IsOpen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimeEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RedmineKey = c.Int(nullable: false),
                        IssueId = c.Int(nullable: false),
                        SpentOn = c.DateTime(nullable: false),
                        Hours = c.Double(nullable: false),
                        ActivityId = c.Int(nullable: false),
                        Comments = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeEntries");
            DropTable("dbo.Issues");
            DropTable("dbo.Activities");
        }
    }
}
