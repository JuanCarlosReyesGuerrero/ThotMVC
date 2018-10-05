namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Departamentos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asignaturas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Nombre = c.String(nullable: false, maxLength: 255),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.Sedes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        CodigoDaneNuevo = c.String(nullable: false),
                        CodigoDaneAntiguo = c.String(nullable: false),
                        CodigoConsecutivo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        DepartamentoId = c.Long(nullable: false),
                        MunicipioId = c.Long(nullable: false),
                        ZonaId = c.Long(nullable: false),
                        Barrio = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        Novedad = c.String(),
                        JornadaCompleta = c.Boolean(nullable: false),
                        JornadaManana = c.Boolean(nullable: false),
                        JornadaTarde = c.Boolean(nullable: false),
                        JornadaNoche = c.Boolean(nullable: false),
                        JornadaFinSemana = c.Boolean(nullable: false),
                        EspecialidadId = c.Long(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        Director = c.String(),
                        Secretaria = c.String(),
                        EscalaValoracionNacional = c.Boolean(nullable: false),
                        RangoNumerico = c.Boolean(nullable: false),
                        NumeroInicial = c.Int(nullable: false),
                        NumeroFinal = c.Int(nullable: false),
                        ValoracionLetras = c.Boolean(nullable: false),
                        Juicios = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Especialidades", t => t.EspecialidadId, cascadeDelete: true)
                .ForeignKey("dbo.Municipios", t => t.MunicipioId, cascadeDelete: true)
                .ForeignKey("dbo.Zonas", t => t.ZonaId, cascadeDelete: true)
                .Index(t => t.DepartamentoId)
                .Index(t => t.MunicipioId)
                .Index(t => t.ZonaId)
                .Index(t => t.EspecialidadId);
            
            CreateTable(
                "dbo.Departamentos",
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
                "dbo.Especialidades",
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
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        CodigoUnificado = c.String(nullable: false),
                        DepartamentoId = c.Long(nullable: false),
                        DepartamentoCode = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: false)
                .Index(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Zonas",
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
            DropForeignKey("dbo.Asignaturas", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Sedes", "ZonaId", "dbo.Zonas");
            DropForeignKey("dbo.Sedes", "MunicipioId", "dbo.Municipios");
            DropForeignKey("dbo.Municipios", "DepartamentoId", "dbo.Departamentos");
            DropForeignKey("dbo.Sedes", "EspecialidadId", "dbo.Especialidades");
            DropForeignKey("dbo.Sedes", "DepartamentoId", "dbo.Departamentos");
            DropIndex("dbo.Municipios", new[] { "DepartamentoId" });
            DropIndex("dbo.Sedes", new[] { "EspecialidadId" });
            DropIndex("dbo.Sedes", new[] { "ZonaId" });
            DropIndex("dbo.Sedes", new[] { "MunicipioId" });
            DropIndex("dbo.Sedes", new[] { "DepartamentoId" });
            DropIndex("dbo.Asignaturas", new[] { "SedeId" });
            DropTable("dbo.Zonas");
            DropTable("dbo.Municipios");
            DropTable("dbo.Especialidades");
            DropTable("dbo.Departamentos");
            DropTable("dbo.Sedes");
            DropTable("dbo.Asignaturas");
        }
    }
}
