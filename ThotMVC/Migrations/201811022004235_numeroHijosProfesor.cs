namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class numeroHijosProfesor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profesores", "NumeroHijos", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "NumeroHijos", c => c.String(nullable: false));
        }
    }
}
