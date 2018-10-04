namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizaDepartamentos : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Departments");
            DropColumn("dbo.Departments", "Id");
            AddColumn("dbo.Departments", "DepartmentId", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Departments", "DepartmentId");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Id", c => c.Long(nullable: false, identity: true));
            DropPrimaryKey("dbo.Departments");
            DropColumn("dbo.Departments", "DepartmentId");
            AddPrimaryKey("dbo.Departments", "Id");
        }
    }
}
