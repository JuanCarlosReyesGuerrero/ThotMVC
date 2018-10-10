namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arregloSedes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EscalaNacionales", "CriterioEvalaluacion", c => c.String(nullable: false));
            AddColumn("dbo.EscalaNacionales", "SedeId", c => c.Long(nullable: false));
            AlterColumn("dbo.EscalaNacionales", "Codigo", c => c.String(nullable: false));
            CreateIndex("dbo.EscalaNacionales", "SedeId");
            AddForeignKey("dbo.EscalaNacionales", "SedeId", "dbo.Sedes", "Id", cascadeDelete: true);
            DropColumn("dbo.EscalaNacionales", "Descripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EscalaNacionales", "Descripcion", c => c.String());
            DropForeignKey("dbo.EscalaNacionales", "SedeId", "dbo.Sedes");
            DropIndex("dbo.EscalaNacionales", new[] { "SedeId" });
            AlterColumn("dbo.EscalaNacionales", "Codigo", c => c.Long(nullable: false));
            DropColumn("dbo.EscalaNacionales", "SedeId");
            DropColumn("dbo.EscalaNacionales", "CriterioEvalaluacion");
        }
    }
}
