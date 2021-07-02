namespace Interview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdToUserIdInUserTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "Id", newName: "UserID");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "UserID", newName: "Id");
        }
    }
}
