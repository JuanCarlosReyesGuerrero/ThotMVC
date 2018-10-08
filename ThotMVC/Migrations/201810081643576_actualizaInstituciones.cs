namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizaInstituciones : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Grados", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Cursos", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Profesores", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Equivalencias", "InstitucionId", "dbo.Instituciones");
            DropIndex("dbo.Cursos", new[] { "InstitucionId" });
            DropIndex("dbo.Grados", new[] { "InstitucionId" });
            DropIndex("dbo.Profesores", new[] { "InstitucionId" });
            DropIndex("dbo.Equivalencias", new[] { "InstitucionId" });
            AddColumn("dbo.Equivalencias", "Nombre", c => c.String(nullable: false));
            AddColumn("dbo.Equivalencias", "Descripcion", c => c.String());
            DropColumn("dbo.Cursos", "InstitucionId");
            DropColumn("dbo.Grados", "InstitucionId");
            DropColumn("dbo.Profesores", "InstitucionId");
            DropColumn("dbo.Equivalencias", "InstitucionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equivalencias", "InstitucionId", c => c.Long(nullable: false));
            AddColumn("dbo.Profesores", "InstitucionId", c => c.Long(nullable: false));
            AddColumn("dbo.Grados", "InstitucionId", c => c.Long(nullable: false));
            AddColumn("dbo.Cursos", "InstitucionId", c => c.Long(nullable: false));
            DropColumn("dbo.Equivalencias", "Descripcion");
            DropColumn("dbo.Equivalencias", "Nombre");
            CreateIndex("dbo.Equivalencias", "InstitucionId");
            CreateIndex("dbo.Profesores", "InstitucionId");
            CreateIndex("dbo.Grados", "InstitucionId");
            CreateIndex("dbo.Cursos", "InstitucionId");
            AddForeignKey("dbo.Equivalencias", "InstitucionId", "dbo.Instituciones", "InstitucionId", cascadeDelete: true);
            AddForeignKey("dbo.Profesores", "InstitucionId", "dbo.Instituciones", "InstitucionId", cascadeDelete: true);
            AddForeignKey("dbo.Cursos", "InstitucionId", "dbo.Instituciones", "InstitucionId", cascadeDelete: true);
            AddForeignKey("dbo.Grados", "InstitucionId", "dbo.Instituciones", "InstitucionId", cascadeDelete: true);
        }
    }
}
