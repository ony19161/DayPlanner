namespace App.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskReminders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(nullable: false),
                        TaskId = c.String(maxLength: 128),
                        RemindBy = c.String(nullable: false),
                        CreationUser = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(nullable: false),
                        LastUpdateTime = c.DateTime(nullable: false),
                        CreatedFrom = c.String(nullable: false),
                        UpdatedFrom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.TaskId)
                .Index(t => t.TaskId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TaskNote = c.String(nullable: false),
                        Type = c.String(),
                        Priority = c.String(),
                        State = c.String(),
                        StartTime = c.String(),
                        EndTime = c.String(),
                        HasReminder = c.Boolean(nullable: false),
                        CreationUser = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(nullable: false),
                        LastUpdateTime = c.DateTime(nullable: false),
                        CreatedFrom = c.String(nullable: false),
                        UpdatedFrom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskStates",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        State = c.String(nullable: false),
                        CreationUser = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(nullable: false),
                        LastUpdateTime = c.DateTime(nullable: false),
                        CreatedFrom = c.String(nullable: false),
                        UpdatedFrom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Type = c.String(nullable: false),
                        CreationUser = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(nullable: false),
                        LastUpdateTime = c.DateTime(nullable: false),
                        CreatedFrom = c.String(nullable: false),
                        UpdatedFrom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskReminders", "TaskId", "dbo.Tasks");
            DropIndex("dbo.TaskReminders", new[] { "TaskId" });
            DropTable("dbo.TaskTypes");
            DropTable("dbo.TaskStates");
            DropTable("dbo.Tasks");
            DropTable("dbo.TaskReminders");
        }
    }
}
