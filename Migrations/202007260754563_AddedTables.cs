namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StatusDetails",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusTitle = c.String(),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.TaskDetails",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        TaskTitle = c.String(),
                        TaskDescription = c.String(),
                        CreatedBy = c.String(),
                        TaskStatusID = c.Int(nullable: false),
                        Status_StatusID = c.Int(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.StatusDetails", t => t.Status_StatusID)
                .Index(t => t.Status_StatusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskDetails", "Status_StatusID", "dbo.StatusDetails");
            DropIndex("dbo.TaskDetails", new[] { "Status_StatusID" });
            DropTable("dbo.TaskDetails");
            DropTable("dbo.StatusDetails");
        }
    }
}
