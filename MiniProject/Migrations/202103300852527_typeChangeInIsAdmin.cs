namespace MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeChangeInIsAdmin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "isAdmin", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "isAdmin", c => c.Boolean(nullable: false));
        }
    }
}
