namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profesores4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profesores", "SegundoApellido", c => c.String());
            AlterColumn("dbo.Profesores", "SegundoNombre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "SegundoNombre", c => c.String(nullable: false));
            AlterColumn("dbo.Profesores", "SegundoApellido", c => c.String(nullable: false));
        }
    }
}
