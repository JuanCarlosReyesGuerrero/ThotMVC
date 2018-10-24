namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estudiantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        CodigoMEN = c.String(nullable: false),
                        TipoIdentificacionId = c.Long(nullable: false),
                        NumeroDocumento = c.String(nullable: false),
                        DepartamentoExpedicionId = c.Long(nullable: false),
                        MunicipioExpedicionId = c.Long(nullable: false),
                        PrimerApellido = c.String(nullable: false),
                        SegundoApellido = c.String(nullable: false),
                        PrimerNombre = c.String(nullable: false),
                        SegundoNombre = c.String(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        DepartamentoNacimientoId = c.Long(nullable: false),
                        MunicipioNacimientoId = c.Long(nullable: false),
                        GeneroId = c.Long(nullable: false),
                        FactorRhId = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Fotografia = c.String(),
                        Direccion = c.String(nullable: false),
                        DepartamentoResidenciaId = c.Long(nullable: false),
                        MunicipioResidenciaId = c.Long(nullable: false),
                        ZonaResidenciaId = c.Long(nullable: false),
                        Localidad = c.String(nullable: false),
                        Barrio = c.String(nullable: false),
                        EstratoId = c.Long(nullable: false),
                        Telefono = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        SisbenId = c.Long(nullable: false),
                        NumeroSisben = c.String(nullable: false),
                        EpsId = c.Long(nullable: false),
                        ArsId = c.Long(nullable: false),
                        PoblacionVictimaId = c.Long(nullable: false),
                        DepartamentoExpulsorId = c.Long(nullable: false),
                        MunicipioExpulsorId = c.Long(nullable: false),
                        FechaExpulsion = c.DateTime(),
                        CertificadoExpulsion = c.String(nullable: false),
                        FechaCertificadoExpulsion = c.DateTime(),
                        DiscapacidadId = c.Long(nullable: false),
                        CapacidadExcepcionalId = c.Long(nullable: false),
                        EtniaId = c.Long(nullable: false),
                        ResguardoId = c.Long(nullable: false),
                        ProvieneSectorPrivado = c.Boolean(nullable: false),
                        ProvieneOtroMunicipio = c.Boolean(nullable: false),
                        InstitucionBienestar = c.String(nullable: false),
                        TipoIdentificacionMadreId = c.Long(nullable: false),
                        NumeroDocumentoMadre = c.String(nullable: false),
                        DepartamentoExpedicionMadreId = c.Long(nullable: false),
                        MunicipioExpedicionMadreId = c.Long(nullable: false),
                        EstudiantePrimerApellidoMadre = c.String(nullable: false),
                        SegundoApellidoMadre = c.String(nullable: false),
                        PrimerNombreMadre = c.String(nullable: false),
                        EstudianteSegundoNombreMadre = c.String(nullable: false),
                        EmailMadre = c.String(nullable: false),
                        DireccionMadre = c.String(nullable: false),
                        DepartamentoResidenciaMadreId = c.Long(nullable: false),
                        MunicipioResidenciaMadreId = c.Long(nullable: false),
                        ZonaResidenciaMadreId = c.Long(nullable: false),
                        BarrioMadre = c.String(nullable: false),
                        LocalidadMadre = c.String(nullable: false),
                        TelefonoMadre = c.String(nullable: false),
                        CelularMadre = c.String(nullable: false),
                        OcupacionMadre = c.String(nullable: false),
                        EmpresaMadre = c.String(nullable: false),
                        TelefonoEmpresaMadre = c.String(nullable: false),
                        TipoIdentificacionPadreId = c.Long(nullable: false),
                        NumeroDocumentoPadre = c.String(nullable: false),
                        DepartamentoExpedicionPadreId = c.Long(nullable: false),
                        MunicipioExpedicionPadreId = c.Long(nullable: false),
                        PrimerApellidoPadre = c.String(nullable: false),
                        SegundoApellidoPadre = c.String(nullable: false),
                        PrimerNombrePadre = c.String(nullable: false),
                        SegundoNombrePadre = c.String(nullable: false),
                        EmailPadre = c.String(nullable: false),
                        DireccionPadre = c.String(nullable: false),
                        DepartamentoResidenciaPadreId = c.Long(nullable: false),
                        MunicipioResidenciaPadreId = c.Long(nullable: false),
                        ZonaResicenciaPadreId = c.Long(nullable: false),
                        BarrioPadre = c.String(nullable: false),
                        Localidadpadre = c.String(nullable: false),
                        TelefonoPadre = c.String(nullable: false),
                        CelularPadre = c.String(nullable: false),
                        OcupacionPadre = c.String(nullable: false),
                        EmpresaPadre = c.String(nullable: false),
                        TelefonoEmpresaPadre = c.String(nullable: false),
                        TipoIdentificacionAcudienteId = c.Long(nullable: false),
                        NumeroDocumentoAcudiente = c.String(nullable: false),
                        DepartamentoExpedicionAcudienteId = c.Long(nullable: false),
                        MunicipioExpedicionAcudiente = c.Long(nullable: false),
                        PrimerApellidoAcudiente = c.String(nullable: false),
                        SegundoApellidoAcudiente = c.String(nullable: false),
                        PrimerNombreAcudiente = c.String(nullable: false),
                        SegundoNombreAcudiente = c.String(nullable: false),
                        EmailAcudiente = c.String(nullable: false),
                        DireccionAcudiente = c.String(nullable: false),
                        DepartamentoResidenciaAcudienteId = c.Long(nullable: false),
                        MunicipioResidenciaAcudienteId = c.Long(nullable: false),
                        ZonaResidenciaAcudienteId = c.Long(nullable: false),
                        BarrioAcudiente = c.String(nullable: false),
                        LocalidadAcudiente = c.String(nullable: false),
                        TelefonoAcudiente = c.String(nullable: false),
                        CelularAcudiente = c.String(nullable: false),
                        OcupacionAcudiente = c.String(nullable: false),
                        EmpresaAcudiente = c.String(nullable: false),
                        TelefonoEmpresaAcudiente = c.String(nullable: false),
                        GeneroAcudienteId = c.Long(nullable: false),
                        ParentescoAcudienteId = c.Long(nullable: false),
                        ColegioUltimoCurso = c.String(nullable: false),
                        DireccionColegioUltimoCurso = c.String(nullable: false),
                        TelefonoColegioUltimoCurso = c.String(nullable: false),
                        UltimoGrado = c.String(nullable: false),
                        Anio = c.String(nullable: false),
                        MotivoRetiroUltimo = c.String(nullable: false),
                        Observaciones = c.String(nullable: false),
                        UsuarioEstudiante = c.String(nullable: false),
                        ClaveAcceso = c.String(nullable: false),
                        GrupoUsuarioId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        InstitucionId = c.Long(nullable: false),
                        SeleccioneMadre = c.Boolean(nullable: false),
                        SeleccionePadre = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                        Departamentos_Id = c.Long(),
                        Municipios_Id = c.Long(),
                        Zonas_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ars", t => t.ArsId, cascadeDelete: true)
                .ForeignKey("dbo.CapacidadExcepcionales", t => t.CapacidadExcepcionalId, cascadeDelete: true)
                .ForeignKey("dbo.Departamentos", t => t.Departamentos_Id)
                .ForeignKey("dbo.Eps", t => t.EpsId, cascadeDelete: true)
                .ForeignKey("dbo.Estratos", t => t.EstratoId, cascadeDelete: true)
                .ForeignKey("dbo.Etnias", t => t.EtniaId, cascadeDelete: true)
                .ForeignKey("dbo.FactorRhs", t => t.FactorRhId, cascadeDelete: true)
                .ForeignKey("dbo.Generos", t => t.GeneroId, cascadeDelete: true)
                .ForeignKey("dbo.Grupos", t => t.GrupoUsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Instituciones", t => t.InstitucionId, cascadeDelete: false)
                .ForeignKey("dbo.Municipios", t => t.Municipios_Id)
                .ForeignKey("dbo.Parentescos", t => t.ParentescoAcudienteId, cascadeDelete: true)
                .ForeignKey("dbo.PoblacionVictimaConflictos", t => t.PoblacionVictimaId, cascadeDelete: true)
                .ForeignKey("dbo.Resguardos", t => t.ResguardoId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .ForeignKey("dbo.Sisbenes", t => t.SisbenId, cascadeDelete: true)
                .ForeignKey("dbo.TipoDiscapacidades", t => t.DiscapacidadId, cascadeDelete: true)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .ForeignKey("dbo.Zonas", t => t.Zonas_Id)
                .Index(t => t.TipoIdentificacionId)
                .Index(t => t.GeneroId)
                .Index(t => t.FactorRhId)
                .Index(t => t.EstratoId)
                .Index(t => t.SisbenId)
                .Index(t => t.EpsId)
                .Index(t => t.ArsId)
                .Index(t => t.PoblacionVictimaId)
                .Index(t => t.DiscapacidadId)
                .Index(t => t.CapacidadExcepcionalId)
                .Index(t => t.EtniaId)
                .Index(t => t.ResguardoId)
                .Index(t => t.ParentescoAcudienteId)
                .Index(t => t.GrupoUsuarioId)
                .Index(t => t.SedeId)
                .Index(t => t.InstitucionId)
                .Index(t => t.Departamentos_Id)
                .Index(t => t.Municipios_Id)
                .Index(t => t.Zonas_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estudiantes", "Zonas_Id", "dbo.Zonas");
            DropForeignKey("dbo.Estudiantes", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Estudiantes", "DiscapacidadId", "dbo.TipoDiscapacidades");
            DropForeignKey("dbo.Estudiantes", "SisbenId", "dbo.Sisbenes");
            DropForeignKey("dbo.Estudiantes", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Estudiantes", "ResguardoId", "dbo.Resguardos");
            DropForeignKey("dbo.Estudiantes", "PoblacionVictimaId", "dbo.PoblacionVictimaConflictos");
            DropForeignKey("dbo.Estudiantes", "ParentescoAcudienteId", "dbo.Parentescos");
            DropForeignKey("dbo.Estudiantes", "Municipios_Id", "dbo.Municipios");
            DropForeignKey("dbo.Estudiantes", "InstitucionId", "dbo.Instituciones");
            DropForeignKey("dbo.Estudiantes", "GrupoUsuarioId", "dbo.Grupos");
            DropForeignKey("dbo.Estudiantes", "GeneroId", "dbo.Generos");
            DropForeignKey("dbo.Estudiantes", "FactorRhId", "dbo.FactorRhs");
            DropForeignKey("dbo.Estudiantes", "EtniaId", "dbo.Etnias");
            DropForeignKey("dbo.Estudiantes", "EstratoId", "dbo.Estratos");
            DropForeignKey("dbo.Estudiantes", "EpsId", "dbo.Eps");
            DropForeignKey("dbo.Estudiantes", "Departamentos_Id", "dbo.Departamentos");
            DropForeignKey("dbo.Estudiantes", "CapacidadExcepcionalId", "dbo.CapacidadExcepcionales");
            DropForeignKey("dbo.Estudiantes", "ArsId", "dbo.Ars");
            DropIndex("dbo.Estudiantes", new[] { "Zonas_Id" });
            DropIndex("dbo.Estudiantes", new[] { "Municipios_Id" });
            DropIndex("dbo.Estudiantes", new[] { "Departamentos_Id" });
            DropIndex("dbo.Estudiantes", new[] { "InstitucionId" });
            DropIndex("dbo.Estudiantes", new[] { "SedeId" });
            DropIndex("dbo.Estudiantes", new[] { "GrupoUsuarioId" });
            DropIndex("dbo.Estudiantes", new[] { "ParentescoAcudienteId" });
            DropIndex("dbo.Estudiantes", new[] { "ResguardoId" });
            DropIndex("dbo.Estudiantes", new[] { "EtniaId" });
            DropIndex("dbo.Estudiantes", new[] { "CapacidadExcepcionalId" });
            DropIndex("dbo.Estudiantes", new[] { "DiscapacidadId" });
            DropIndex("dbo.Estudiantes", new[] { "PoblacionVictimaId" });
            DropIndex("dbo.Estudiantes", new[] { "ArsId" });
            DropIndex("dbo.Estudiantes", new[] { "EpsId" });
            DropIndex("dbo.Estudiantes", new[] { "SisbenId" });
            DropIndex("dbo.Estudiantes", new[] { "EstratoId" });
            DropIndex("dbo.Estudiantes", new[] { "FactorRhId" });
            DropIndex("dbo.Estudiantes", new[] { "GeneroId" });
            DropIndex("dbo.Estudiantes", new[] { "TipoIdentificacionId" });
            DropTable("dbo.Estudiantes");
        }
    }
}
