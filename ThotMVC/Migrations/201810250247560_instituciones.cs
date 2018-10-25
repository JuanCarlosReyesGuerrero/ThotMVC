namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instituciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instituciones", "JornadaCompletaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaMananaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaTardeId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaNocturnaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaFinSemanaId", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Instituciones", "NombreRector", c => c.String());
            AlterColumn("dbo.Instituciones", "Barrio", c => c.String(nullable: false));
            AlterColumn("dbo.Instituciones", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.Instituciones", "Telefono", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Instituciones", "Telefono", c => c.String());
            AlterColumn("dbo.Instituciones", "Direccion", c => c.String());
            AlterColumn("dbo.Instituciones", "Barrio", c => c.String());
            AlterColumn("dbo.Instituciones", "NombreRector", c => c.String(nullable: false));
            DropColumn("dbo.Instituciones", "JornadaFinSemanaId");
            DropColumn("dbo.Instituciones", "JornadaNocturnaId");
            DropColumn("dbo.Instituciones", "JornadaTardeId");
            DropColumn("dbo.Instituciones", "JornadaMananaId");
            DropColumn("dbo.Instituciones", "JornadaCompletaId");
        }
    }
}
