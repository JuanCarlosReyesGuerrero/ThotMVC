namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profesores : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profesores", "GeneroId", c => c.Long(nullable: false));
            AddColumn("dbo.Profesores", "FechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Profesores", "LugarNacimiento", c => c.String(nullable: false));
            AddColumn("dbo.Profesores", "EstadoCivilId", c => c.Long(nullable: false));
            AddColumn("dbo.Profesores", "NumeroHijos", c => c.String(nullable: false));
            AddColumn("dbo.Profesores", "FechaVinculacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Profesores", "FechaRetiro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Profesores", "LibretaMilitar", c => c.String(nullable: false));
            AddColumn("dbo.Profesores", "ResolucionNombramiento", c => c.String(nullable: false));
            AddColumn("dbo.Profesores", "FotoPerfil", c => c.String(nullable: false));
            CreateIndex("dbo.Profesores", "GeneroId");
            CreateIndex("dbo.Profesores", "EstadoCivilId");
            AddForeignKey("dbo.Profesores", "EstadoCivilId", "dbo.EstadoCiviles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Profesores", "GeneroId", "dbo.Generos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profesores", "GeneroId", "dbo.Generos");
            DropForeignKey("dbo.Profesores", "EstadoCivilId", "dbo.EstadoCiviles");
            DropIndex("dbo.Profesores", new[] { "EstadoCivilId" });
            DropIndex("dbo.Profesores", new[] { "GeneroId" });
            DropColumn("dbo.Profesores", "FotoPerfil");
            DropColumn("dbo.Profesores", "ResolucionNombramiento");
            DropColumn("dbo.Profesores", "LibretaMilitar");
            DropColumn("dbo.Profesores", "FechaRetiro");
            DropColumn("dbo.Profesores", "FechaVinculacion");
            DropColumn("dbo.Profesores", "NumeroHijos");
            DropColumn("dbo.Profesores", "EstadoCivilId");
            DropColumn("dbo.Profesores", "LugarNacimiento");
            DropColumn("dbo.Profesores", "FechaNacimiento");
            DropColumn("dbo.Profesores", "GeneroId");
        }
    }
}
