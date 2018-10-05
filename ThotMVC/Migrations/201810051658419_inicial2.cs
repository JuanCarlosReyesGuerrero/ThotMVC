namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsociacionPrivadas",
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
            
            CreateTable(
                "dbo.Calendarios",
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
            
            CreateTable(
                "dbo.CapacidadExcepcionales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Escalafones",
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
            
            CreateTable(
                "dbo.Estratos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etnias",
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
            
            CreateTable(
                "dbo.FuenteRecursos",
                c => new
                    {
                        FuenteRecursoId = c.Long(nullable: false, identity: true),
                        FuenteRecursoCodigo = c.Long(nullable: false),
                        FuenteRecursoNombre = c.String(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.FuenteRecursoId);
            
            CreateTable(
                "dbo.Generos",
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
            
            CreateTable(
                "dbo.Idiomas",
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
            
            CreateTable(
                "dbo.Jornadas",
                c => new
                    {
                        JornadaId = c.Long(nullable: false, identity: true),
                        JornadaCodigo = c.String(nullable: false),
                        JornadaNombre = c.String(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.JornadaId)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .Index(t => t.SedeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jornadas", "SedeId", "dbo.Sedes");
            DropIndex("dbo.Jornadas", new[] { "SedeId" });
            DropTable("dbo.Jornadas");
            DropTable("dbo.Idiomas");
            DropTable("dbo.Generos");
            DropTable("dbo.FuenteRecursos");
            DropTable("dbo.Etnias");
            DropTable("dbo.Estratos");
            DropTable("dbo.Escalafones");
            DropTable("dbo.CapacidadExcepcionales");
            DropTable("dbo.Calendarios");
            DropTable("dbo.AsociacionPrivadas");
        }
    }
}
