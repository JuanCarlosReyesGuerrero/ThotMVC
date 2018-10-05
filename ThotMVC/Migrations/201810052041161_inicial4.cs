namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instituciones",
                c => new
                    {
                        InstitucionId = c.Long(nullable: false, identity: true),
                        InstitucionCodigoDane = c.String(nullable: false),
                        InstitucionNombre = c.String(nullable: false),
                        InstitucionNit = c.String(nullable: false),
                        InstitucionNombreRector = c.String(nullable: false),
                        CalendarioId = c.Long(nullable: false),
                        TipoSectorEducacionId = c.Long(nullable: false),
                        PropiedadJuridicaId = c.Long(nullable: false),
                        InstitucionNumeroSedes = c.Int(nullable: false),
                        NucleoId = c.Long(nullable: false),
                        GeneroId = c.Long(nullable: false),
                        InstitucionSubsidio = c.Boolean(nullable: false),
                        DiscapacidadesId = c.Long(nullable: false),
                        CapacidadesExcepcionalesId = c.Long(nullable: false),
                        EtniasId = c.Long(nullable: false),
                        ResguardosId = c.Long(nullable: false),
                        NovedadId = c.Long(nullable: false),
                        MetodologiaId = c.Long(nullable: false),
                        PrestadorServicioId = c.Long(nullable: false),
                        InstitucionDecretoCreacion = c.String(),
                        InstitucionDirector = c.String(),
                        InstitucionSecretaria = c.String(),
                        InstitucionAprobacion = c.String(),
                        InstitucionLema = c.String(),
                        InstitucionEscudo = c.String(),
                        DepartamentoId = c.Long(nullable: false),
                        MunicipioId = c.Long(nullable: false),
                        ZonaId = c.Long(nullable: false),
                        InstitucionBarrio = c.String(),
                        InstitucionDireccion = c.String(),
                        InstitucionTelefono = c.String(),
                        InstitucionFax = c.String(),
                        InstitucionSitioWeb = c.String(),
                        InstitucionEmail = c.String(),
                        InstitucionNumeroLiciencia = c.String(),
                        RegimenCostoId = c.Long(nullable: false),
                        IdiomaId = c.Long(nullable: false),
                        AsociacionId = c.Long(nullable: false),
                        TarifaAnualId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.InstitucionId)
                .ForeignKey("dbo.AsociacionPrivadas", t => t.AsociacionId, cascadeDelete: true)
                .ForeignKey("dbo.Calendarios", t => t.CalendarioId, cascadeDelete: true)
                .ForeignKey("dbo.CapacidadExcepcionales", t => t.CapacidadesExcepcionalesId, cascadeDelete: true)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Etnias", t => t.EtniasId, cascadeDelete: true)
                .ForeignKey("dbo.Generos", t => t.GeneroId, cascadeDelete: true)
                .ForeignKey("dbo.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .ForeignKey("dbo.Metodologias", t => t.MetodologiaId, cascadeDelete: true)
                .ForeignKey("dbo.Municipios", t => t.MunicipioId, cascadeDelete: true)
                .ForeignKey("dbo.Nucleos", t => t.NucleoId, cascadeDelete: false)
                .ForeignKey("dbo.Prestadores", t => t.PrestadorServicioId, cascadeDelete: true)
                .ForeignKey("dbo.PropiedadJuridicas", t => t.PropiedadJuridicaId, cascadeDelete: true)
                .ForeignKey("dbo.RegimenCostos", t => t.RegimenCostoId, cascadeDelete: true)
                .ForeignKey("dbo.Resguardos", t => t.ResguardosId, cascadeDelete: true)
                .ForeignKey("dbo.TarifaAnuales", t => t.TarifaAnualId, cascadeDelete: true)
                .ForeignKey("dbo.TipoDiscapacidades", t => t.DiscapacidadesId, cascadeDelete: true)
                .ForeignKey("dbo.TipoNovedades", t => t.NovedadId, cascadeDelete: true)
                .ForeignKey("dbo.TipoSectorEducaciones", t => t.TipoSectorEducacionId, cascadeDelete: true)
                .ForeignKey("dbo.Zonas", t => t.ZonaId, cascadeDelete: true)
                .Index(t => t.CalendarioId)
                .Index(t => t.TipoSectorEducacionId)
                .Index(t => t.PropiedadJuridicaId)
                .Index(t => t.NucleoId)
                .Index(t => t.GeneroId)
                .Index(t => t.DiscapacidadesId)
                .Index(t => t.CapacidadesExcepcionalesId)
                .Index(t => t.EtniasId)
                .Index(t => t.ResguardosId)
                .Index(t => t.NovedadId)
                .Index(t => t.MetodologiaId)
                .Index(t => t.PrestadorServicioId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.MunicipioId)
                .Index(t => t.ZonaId)
                .Index(t => t.RegimenCostoId)
                .Index(t => t.IdiomaId)
                .Index(t => t.AsociacionId)
                .Index(t => t.TarifaAnualId);
            
            CreateTable(
                "dbo.PoblacionVictimaConflictos",
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
                "dbo.Profesiones",
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
                "dbo.Sisbenes",
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
                "dbo.SituacionAcademicas",
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
                "dbo.TipoCaracteres",
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
                "dbo.TipoCondiciones",
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
                "dbo.TipoIdentificaciones",
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
                "dbo.TipoRespuestas",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instituciones", "ZonaId", "dbo.Zonas");
            DropForeignKey("dbo.Instituciones", "TipoSectorEducacionId", "dbo.TipoSectorEducaciones");
            DropForeignKey("dbo.Instituciones", "NovedadId", "dbo.TipoNovedades");
            DropForeignKey("dbo.Instituciones", "DiscapacidadesId", "dbo.TipoDiscapacidades");
            DropForeignKey("dbo.Instituciones", "TarifaAnualId", "dbo.TarifaAnuales");
            DropForeignKey("dbo.Instituciones", "ResguardosId", "dbo.Resguardos");
            DropForeignKey("dbo.Instituciones", "RegimenCostoId", "dbo.RegimenCostos");
            DropForeignKey("dbo.Instituciones", "PropiedadJuridicaId", "dbo.PropiedadJuridicas");
            DropForeignKey("dbo.Instituciones", "PrestadorServicioId", "dbo.Prestadores");
            DropForeignKey("dbo.Instituciones", "NucleoId", "dbo.Nucleos");
            DropForeignKey("dbo.Instituciones", "MunicipioId", "dbo.Municipios");
            DropForeignKey("dbo.Instituciones", "MetodologiaId", "dbo.Metodologias");
            DropForeignKey("dbo.Instituciones", "IdiomaId", "dbo.Idiomas");
            DropForeignKey("dbo.Instituciones", "GeneroId", "dbo.Generos");
            DropForeignKey("dbo.Instituciones", "EtniasId", "dbo.Etnias");
            DropForeignKey("dbo.Instituciones", "DepartamentoId", "dbo.Departamentos");
            DropForeignKey("dbo.Instituciones", "CapacidadesExcepcionalesId", "dbo.CapacidadExcepcionales");
            DropForeignKey("dbo.Instituciones", "CalendarioId", "dbo.Calendarios");
            DropForeignKey("dbo.Instituciones", "AsociacionId", "dbo.AsociacionPrivadas");
            DropIndex("dbo.Instituciones", new[] { "TarifaAnualId" });
            DropIndex("dbo.Instituciones", new[] { "AsociacionId" });
            DropIndex("dbo.Instituciones", new[] { "IdiomaId" });
            DropIndex("dbo.Instituciones", new[] { "RegimenCostoId" });
            DropIndex("dbo.Instituciones", new[] { "ZonaId" });
            DropIndex("dbo.Instituciones", new[] { "MunicipioId" });
            DropIndex("dbo.Instituciones", new[] { "DepartamentoId" });
            DropIndex("dbo.Instituciones", new[] { "PrestadorServicioId" });
            DropIndex("dbo.Instituciones", new[] { "MetodologiaId" });
            DropIndex("dbo.Instituciones", new[] { "NovedadId" });
            DropIndex("dbo.Instituciones", new[] { "ResguardosId" });
            DropIndex("dbo.Instituciones", new[] { "EtniasId" });
            DropIndex("dbo.Instituciones", new[] { "CapacidadesExcepcionalesId" });
            DropIndex("dbo.Instituciones", new[] { "DiscapacidadesId" });
            DropIndex("dbo.Instituciones", new[] { "GeneroId" });
            DropIndex("dbo.Instituciones", new[] { "NucleoId" });
            DropIndex("dbo.Instituciones", new[] { "PropiedadJuridicaId" });
            DropIndex("dbo.Instituciones", new[] { "TipoSectorEducacionId" });
            DropIndex("dbo.Instituciones", new[] { "CalendarioId" });
            DropTable("dbo.TipoRespuestas");
            DropTable("dbo.TipoIdentificaciones");
            DropTable("dbo.TipoCondiciones");
            DropTable("dbo.TipoCaracteres");
            DropTable("dbo.SituacionAcademicas");
            DropTable("dbo.Sisbenes");
            DropTable("dbo.Profesiones");
            DropTable("dbo.PoblacionVictimaConflictos");
            DropTable("dbo.Instituciones");
        }
    }
}
