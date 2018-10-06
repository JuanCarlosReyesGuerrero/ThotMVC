namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AporteParafiscales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ars",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClasesFuncionarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        GradoId = c.Long(nullable: false),
                        GrupoId = c.Long(nullable: false),
                        JornadaId = c.Long(nullable: false),
                        ProfesorId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        InstitucionId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: true)
                .ForeignKey("dbo.Grupos", t => t.GrupoId, cascadeDelete: true)
                .ForeignKey("dbo.Instituciones", t => t.InstitucionId, cascadeDelete: true)
                .ForeignKey("dbo.Jornadas", t => t.JornadaId, cascadeDelete: false)
                .ForeignKey("dbo.Profesores", t => t.ProfesorId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .Index(t => t.GradoId)
                .Index(t => t.GrupoId)
                .Index(t => t.JornadaId)
                .Index(t => t.ProfesorId)
                .Index(t => t.SedeId)
                .Index(t => t.InstitucionId);
            
            CreateTable(
                "dbo.Grados",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        SedeId = c.Long(nullable: false),
                        InstitucionId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instituciones", t => t.InstitucionId, cascadeDelete: false)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .Index(t => t.SedeId)
                .Index(t => t.InstitucionId);
            
            CreateTable(
                "dbo.Grupos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profesores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        TipoIdentificacionId = c.Long(nullable: false),
                        NumeroDocumento = c.String(nullable: false),
                        PrimerApellido = c.String(nullable: false),
                        SegundoApellido = c.String(nullable: false),
                        PrimerNombre = c.String(nullable: false),
                        SegundoNombre = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        ProfesionId = c.Long(nullable: false),
                        EscalafonId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        InstitucionId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escalafones", t => t.EscalafonId, cascadeDelete: true)
                .ForeignKey("dbo.Instituciones", t => t.InstitucionId, cascadeDelete: false)
                .ForeignKey("dbo.Profesiones", t => t.ProfesionId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.TipoIdentificacionId)
                .Index(t => t.ProfesionId)
                .Index(t => t.EscalafonId)
                .Index(t => t.SedeId)
                .Index(t => t.InstitucionId);
            
            CreateTable(
                "dbo.Eps",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equivalencias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        EquivalenciaRangoNumerico = c.String(nullable: false),
                        ValoracionLetraId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        InstitucionId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instituciones", t => t.InstitucionId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .ForeignKey("dbo.ValoracionLetras", t => t.ValoracionLetraId, cascadeDelete: true)
                .Index(t => t.ValoracionLetraId)
                .Index(t => t.SedeId)
                .Index(t => t.InstitucionId);
            
            CreateTable(
                "dbo.ValoracionLetras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        ValorNumerico = c.Int(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.EscalaNacionales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstadoCiviles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equivalencias", "ValoracionLetraId", "dbo.ValoracionLetras");
            DropForeignKey("dbo.ValoracionLetras", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Equivalencias", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Equivalencias", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Cursos", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Cursos", "ProfesorId", "dbo.Profesores");
            DropForeignKey("dbo.Profesores", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Profesores", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Profesores", "ProfesionId", "dbo.Profesiones");
            DropForeignKey("dbo.Profesores", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Profesores", "EscalafonId", "dbo.Escalafones");
            DropForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Cursos", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Cursos", "GrupoId", "dbo.Grupos");
            DropForeignKey("dbo.Cursos", "GradoId", "dbo.Grados");
            DropForeignKey("dbo.Grados", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Grados", "InstitucionId", "dbo.Instituciones");
            DropIndex("dbo.ValoracionLetras", new[] { "SedeId" });
            DropIndex("dbo.Equivalencias", new[] { "InstitucionId" });
            DropIndex("dbo.Equivalencias", new[] { "SedeId" });
            DropIndex("dbo.Equivalencias", new[] { "ValoracionLetraId" });
            DropIndex("dbo.Profesores", new[] { "InstitucionId" });
            DropIndex("dbo.Profesores", new[] { "SedeId" });
            DropIndex("dbo.Profesores", new[] { "EscalafonId" });
            DropIndex("dbo.Profesores", new[] { "ProfesionId" });
            DropIndex("dbo.Profesores", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Grados", new[] { "InstitucionId" });
            DropIndex("dbo.Grados", new[] { "SedeId" });
            DropIndex("dbo.Cursos", new[] { "InstitucionId" });
            DropIndex("dbo.Cursos", new[] { "SedeId" });
            DropIndex("dbo.Cursos", new[] { "ProfesorId" });
            DropIndex("dbo.Cursos", new[] { "JornadaId" });
            DropIndex("dbo.Cursos", new[] { "GrupoId" });
            DropIndex("dbo.Cursos", new[] { "GradoId" });
            DropTable("dbo.EstadoCiviles");
            DropTable("dbo.EscalaNacionales");
            DropTable("dbo.ValoracionLetras");
            DropTable("dbo.Equivalencias");
            DropTable("dbo.Eps");
            DropTable("dbo.Profesores");
            DropTable("dbo.Grupos");
            DropTable("dbo.Grados");
            DropTable("dbo.Cursos");
            DropTable("dbo.ClasesFuncionarios");
            DropTable("dbo.Cargos");
            DropTable("dbo.Ars");
            DropTable("dbo.AporteParafiscales");
        }
    }
}
