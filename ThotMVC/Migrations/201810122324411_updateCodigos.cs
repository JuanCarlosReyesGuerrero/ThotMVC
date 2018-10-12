namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCodigos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursos", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Profesores", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Equivalencias", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Juicios", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Materias", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Periodos", "Codigo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Periodos", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Materias", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Juicios", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Equivalencias", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Profesores", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Cursos", "Codigo", c => c.Long(nullable: false));
        }
    }
}
