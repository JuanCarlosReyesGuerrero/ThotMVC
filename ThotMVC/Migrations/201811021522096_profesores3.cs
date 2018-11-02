namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profesores3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profesores", "LibretaMilitar", c => c.String());
            AlterColumn("dbo.Profesores", "ResolucionNombramiento", c => c.String());
            AlterColumn("dbo.Profesores", "FotoPerfil", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "FotoPerfil", c => c.String(nullable: false));
            AlterColumn("dbo.Profesores", "ResolucionNombramiento", c => c.String(nullable: false));
            AlterColumn("dbo.Profesores", "LibretaMilitar", c => c.String(nullable: false));
        }
    }
}
