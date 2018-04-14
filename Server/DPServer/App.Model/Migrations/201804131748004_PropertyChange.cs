namespace App.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskReminders", "CreatedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskReminders", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskReminders", "ModifiedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskReminders", "ModifiedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskReminders", "ModifiedFrom", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "CreatedBy", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "ModifiedBy", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "ModifiedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "ModifiedFrom", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "CreatedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskStates", "ModifiedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "ModifiedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskStates", "ModifiedFrom", c => c.String(nullable: false));
            AddColumn("dbo.TaskTypes", "CreatedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskTypes", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskTypes", "ModifiedBy", c => c.String(nullable: false));
            AddColumn("dbo.TaskTypes", "ModifiedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskTypes", "ModifiedFrom", c => c.String(nullable: false));
            DropColumn("dbo.TaskReminders", "CreationUser");
            DropColumn("dbo.TaskReminders", "CreationTime");
            DropColumn("dbo.TaskReminders", "LastUpdateUser");
            DropColumn("dbo.TaskReminders", "LastUpdateTime");
            DropColumn("dbo.TaskReminders", "UpdatedFrom");
            DropColumn("dbo.Tasks", "CreationUser");
            DropColumn("dbo.Tasks", "CreationTime");
            DropColumn("dbo.Tasks", "LastUpdateUser");
            DropColumn("dbo.Tasks", "LastUpdateTime");
            DropColumn("dbo.Tasks", "UpdatedFrom");
            DropColumn("dbo.TaskStates", "CreationUser");
            DropColumn("dbo.TaskStates", "CreationTime");
            DropColumn("dbo.TaskStates", "LastUpdateUser");
            DropColumn("dbo.TaskStates", "LastUpdateTime");
            DropColumn("dbo.TaskStates", "UpdatedFrom");
            DropColumn("dbo.TaskTypes", "CreationUser");
            DropColumn("dbo.TaskTypes", "CreationTime");
            DropColumn("dbo.TaskTypes", "LastUpdateUser");
            DropColumn("dbo.TaskTypes", "LastUpdateTime");
            DropColumn("dbo.TaskTypes", "UpdatedFrom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaskTypes", "UpdatedFrom", c => c.String(nullable: false));
            AddColumn("dbo.TaskTypes", "LastUpdateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskTypes", "LastUpdateUser", c => c.String(nullable: false));
            AddColumn("dbo.TaskTypes", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskTypes", "CreationUser", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "UpdatedFrom", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "LastUpdateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskStates", "LastUpdateUser", c => c.String(nullable: false));
            AddColumn("dbo.TaskStates", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskStates", "CreationUser", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "UpdatedFrom", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "LastUpdateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "LastUpdateUser", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "CreationUser", c => c.String(nullable: false));
            AddColumn("dbo.TaskReminders", "UpdatedFrom", c => c.String(nullable: false));
            AddColumn("dbo.TaskReminders", "LastUpdateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskReminders", "LastUpdateUser", c => c.String(nullable: false));
            AddColumn("dbo.TaskReminders", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskReminders", "CreationUser", c => c.String(nullable: false));
            DropColumn("dbo.TaskTypes", "ModifiedFrom");
            DropColumn("dbo.TaskTypes", "ModifiedAt");
            DropColumn("dbo.TaskTypes", "ModifiedBy");
            DropColumn("dbo.TaskTypes", "CreatedAt");
            DropColumn("dbo.TaskTypes", "CreatedBy");
            DropColumn("dbo.TaskStates", "ModifiedFrom");
            DropColumn("dbo.TaskStates", "ModifiedAt");
            DropColumn("dbo.TaskStates", "ModifiedBy");
            DropColumn("dbo.TaskStates", "CreatedAt");
            DropColumn("dbo.TaskStates", "CreatedBy");
            DropColumn("dbo.Tasks", "ModifiedFrom");
            DropColumn("dbo.Tasks", "ModifiedAt");
            DropColumn("dbo.Tasks", "ModifiedBy");
            DropColumn("dbo.Tasks", "CreatedAt");
            DropColumn("dbo.Tasks", "CreatedBy");
            DropColumn("dbo.TaskReminders", "ModifiedFrom");
            DropColumn("dbo.TaskReminders", "ModifiedAt");
            DropColumn("dbo.TaskReminders", "ModifiedBy");
            DropColumn("dbo.TaskReminders", "CreatedAt");
            DropColumn("dbo.TaskReminders", "CreatedBy");
        }
    }
}
