namespace TestProject_gridview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsActive");
        }
    }
}
