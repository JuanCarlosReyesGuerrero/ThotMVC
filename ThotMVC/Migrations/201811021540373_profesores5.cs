namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profesores5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profesores", "FechaRetiro", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "FechaRetiro", c => c.DateTime(nullable: false));
        }
    }
}
