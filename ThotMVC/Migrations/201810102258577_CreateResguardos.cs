namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateResguardos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resguardos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Instituciones", "ResguardosId", c => c.Long(nullable: false));
            CreateIndex("dbo.Instituciones", "ResguardosId");
            AddForeignKey("dbo.Instituciones", "ResguardosId", "dbo.Resguardos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instituciones", "ResguardosId", "dbo.Resguardos");
            DropIndex("dbo.Instituciones", new[] { "ResguardosId" });
            DropColumn("dbo.Instituciones", "ResguardosId");
            DropTable("dbo.Resguardos");
        }
    }
}
