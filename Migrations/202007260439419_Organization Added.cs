namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizationAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrganazationDetails",
                c => new
                    {
                        OrganazationID = c.Int(nullable: false, identity: true),
                        OrganazationName = c.String(),
                    })
                .PrimaryKey(t => t.OrganazationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrganazationDetails");
        }
    }
}
