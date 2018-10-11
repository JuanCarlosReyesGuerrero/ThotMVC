namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInicial1 : DbMigration
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
                        Codigo = c.String(nullable: false),
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
                        Codigo = c.String(nullable: false),
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
                "dbo.Cargos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                        Codigo = c.String(nullable: false),
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
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: true)
                .ForeignKey("dbo.Grupos", t => t.GrupoId, cascadeDelete: true)
                .ForeignKey("dbo.Jornadas", t => t.JornadaId, cascadeDelete: true)
                .ForeignKey("dbo.Profesores", t => t.ProfesorId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .Index(t => t.GradoId)
                .Index(t => t.GrupoId)
                .Index(t => t.JornadaId)
                .Index(t => t.ProfesorId)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.Grados",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
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
                "dbo.Grupos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
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
                "dbo.Jornadas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
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
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escalafones", t => t.EscalafonId, cascadeDelete: true)
                .ForeignKey("dbo.Profesiones", t => t.ProfesionId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.TipoIdentificacionId)
                .Index(t => t.ProfesionId)
                .Index(t => t.EscalafonId)
                .Index(t => t.SedeId);
            
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
                "dbo.Eps",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        EquivalenciaRangoNumerico = c.String(nullable: false),
                        ValoracionLetraId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .ForeignKey("dbo.ValoracionLetras", t => t.ValoracionLetraId, cascadeDelete: true)
                .Index(t => t.ValoracionLetraId)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.ValoracionLetras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        CriterioEvalaluacion = c.String(nullable: false),
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
                "dbo.EstadoCiviles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.Estratos",
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
                "dbo.FactorRhs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.FuenteRecursos",
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
                "dbo.GeneroEstudiantes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.Instituciones",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CodigoDane = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Nit = c.String(nullable: false),
                        NombreRector = c.String(nullable: false),
                        CalendarioId = c.Long(nullable: false),
                        TipoSectorEducacionId = c.Long(nullable: false),
                        PropiedadJuridicaId = c.Long(nullable: false),
                        NumeroSedes = c.Int(nullable: false),
                        NucleoId = c.Long(nullable: false),
                        GeneroId = c.Long(nullable: false),
                        Subsidio = c.Boolean(nullable: false),
                        DiscapacidadesId = c.Long(nullable: false),
                        CapacidadesExcepcionalesId = c.Long(nullable: false),
                        EtniasId = c.Long(nullable: false),
                        ResguardosId = c.Long(nullable: false),
                        NovedadId = c.Long(nullable: false),
                        MetodologiaId = c.Long(nullable: false),
                        PrestadorServicioId = c.Long(nullable: false),
                        DecretoCreacion = c.String(),
                        Director = c.String(),
                        Secretaria = c.String(),
                        Aprobacion = c.String(),
                        Lema = c.String(),
                        Escudo = c.String(),
                        DepartamentoId = c.Long(nullable: false),
                        MunicipioId = c.Long(nullable: false),
                        ZonaId = c.Long(nullable: false),
                        Barrio = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Fax = c.String(),
                        SitioWeb = c.String(),
                        Email = c.String(),
                        NumeroLiciencia = c.String(),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AsociacionPrivadas", t => t.AsociacionId, cascadeDelete: true)
                .ForeignKey("dbo.Calendarios", t => t.CalendarioId, cascadeDelete: true)
                .ForeignKey("dbo.CapacidadExcepcionales", t => t.CapacidadesExcepcionalesId, cascadeDelete: true)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Etnias", t => t.EtniasId, cascadeDelete: true)
                .ForeignKey("dbo.Generos", t => t.GeneroId, cascadeDelete: true)
                .ForeignKey("dbo.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .ForeignKey("dbo.Metodologias", t => t.MetodologiaId, cascadeDelete: true)
                .ForeignKey("dbo.Municipios", t => t.MunicipioId, cascadeDelete: true)
                .ForeignKey("dbo.Nucleos", t => t.NucleoId, cascadeDelete: true)
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
                "dbo.Metodologias",
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
                "dbo.Nucleos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        DepartamentoId = c.Long(nullable: false),
                        MunicipioId = c.Long(nullable: false),
                        NombreDirector = c.String(nullable: false),
                        TelefonoDirector = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: false)
                .ForeignKey("dbo.Municipios", t => t.MunicipioId, cascadeDelete: false)
                .Index(t => t.DepartamentoId)
                .Index(t => t.MunicipioId);
            
            CreateTable(
                "dbo.Prestadores",
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
                "dbo.PropiedadJuridicas",
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
                "dbo.RegimenCostos",
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
            
            CreateTable(
                "dbo.TarifaAnuales",
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
                "dbo.TipoDiscapacidades",
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
                "dbo.TipoNovedades",
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
                "dbo.TipoSectorEducaciones",
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
                "dbo.Juicios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        GradoId = c.Long(nullable: false),
                        GrupoId = c.Long(nullable: false),
                        JornadaId = c.Long(nullable: false),
                        MateriaId = c.Long(nullable: false),
                        PeriodoId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: true)
                .ForeignKey("dbo.Grupos", t => t.GrupoId, cascadeDelete: true)
                .ForeignKey("dbo.Jornadas", t => t.JornadaId, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.MateriaId, cascadeDelete: true)
                .ForeignKey("dbo.Periodos", t => t.PeriodoId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: true)
                .Index(t => t.GradoId)
                .Index(t => t.GrupoId)
                .Index(t => t.JornadaId)
                .Index(t => t.MateriaId)
                .Index(t => t.PeriodoId)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        IntensidadHoraria = c.Int(nullable: false),
                        Orden = c.Int(nullable: false),
                        ClasificacionId = c.Long(nullable: false),
                        ProfesorId = c.Long(nullable: false),
                        GradoId = c.Long(nullable: false),
                        GrupoId = c.Long(nullable: false),
                        JornadaId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        UsuarioRegistra = c.Long(),
                        FechaRegistro = c.DateTime(),
                        UsuarioModifica = c.Long(),
                        FechaModifica = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clasificaciones", t => t.ClasificacionId, cascadeDelete: false)
                .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: false)
                .ForeignKey("dbo.Grupos", t => t.GrupoId, cascadeDelete: false)
                .ForeignKey("dbo.Jornadas", t => t.JornadaId, cascadeDelete: false)
                .ForeignKey("dbo.Profesores", t => t.ProfesorId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .Index(t => t.ClasificacionId)
                .Index(t => t.ProfesorId)
                .Index(t => t.GradoId)
                .Index(t => t.GrupoId)
                .Index(t => t.JornadaId)
                .Index(t => t.SedeId);
            
            CreateTable(
                "dbo.Clasificaciones",
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
                "dbo.Periodos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
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
                "dbo.LibretaMilitares",
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
                "dbo.NivelEducativoDocentes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.NivelEducativos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.Parentescos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
                "dbo.PoblacionVictimaConflictos",
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
                "dbo.SituacionAcademicas",
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
                "dbo.TipoAcademicos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
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
                "dbo.TipoCaracteres",
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
                "dbo.TipoCondiciones",
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
                "dbo.TipoDevengos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
            
            CreateTable(
                "dbo.TipoVinculaciones",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
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
            DropForeignKey("dbo.TipoAcademicos", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Juicios", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Juicios", "PeriodoId", "dbo.Periodos");
            DropForeignKey("dbo.Periodos", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Juicios", "MateriaId", "dbo.Materias");
            DropForeignKey("dbo.Materias", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Materias", "ProfesorId", "dbo.Profesores");
            DropForeignKey("dbo.Materias", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Materias", "GrupoId", "dbo.Grupos");
            DropForeignKey("dbo.Materias", "GradoId", "dbo.Grados");
            DropForeignKey("dbo.Materias", "ClasificacionId", "dbo.Clasificaciones");
            DropForeignKey("dbo.Juicios", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Juicios", "GrupoId", "dbo.Grupos");
            DropForeignKey("dbo.Juicios", "GradoId", "dbo.Grados");
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
            DropForeignKey("dbo.Nucleos", "MunicipioId", "dbo.Municipios");
            DropForeignKey("dbo.Nucleos", "DepartamentoId", "dbo.Departamentos");
            DropForeignKey("dbo.Instituciones", "MunicipioId", "dbo.Municipios");
            DropForeignKey("dbo.Instituciones", "MetodologiaId", "dbo.Metodologias");
            DropForeignKey("dbo.Instituciones", "IdiomaId", "dbo.Idiomas");
            DropForeignKey("dbo.Instituciones", "GeneroId", "dbo.Generos");
            DropForeignKey("dbo.Instituciones", "EtniasId", "dbo.Etnias");
            DropForeignKey("dbo.Instituciones", "DepartamentoId", "dbo.Departamentos");
            DropForeignKey("dbo.Instituciones", "CapacidadesExcepcionalesId", "dbo.CapacidadExcepcionales");
            DropForeignKey("dbo.Instituciones", "CalendarioId", "dbo.Calendarios");
            DropForeignKey("dbo.Instituciones", "AsociacionId", "dbo.AsociacionPrivadas");
            DropForeignKey("dbo.EscalaNacionales", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Equivalencias", "ValoracionLetraId", "dbo.ValoracionLetras");
            DropForeignKey("dbo.ValoracionLetras", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Equivalencias", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Cursos", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Cursos", "ProfesorId", "dbo.Profesores");
            DropForeignKey("dbo.Profesores", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Profesores", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Profesores", "ProfesionId", "dbo.Profesiones");
            DropForeignKey("dbo.Profesores", "EscalafonId", "dbo.Escalafones");
            DropForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Jornadas", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Cursos", "GrupoId", "dbo.Grupos");
            DropForeignKey("dbo.Grupos", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Cursos", "GradoId", "dbo.Grados");
            DropForeignKey("dbo.Grados", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Asignaturas", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Sedes", "ZonaId", "dbo.Zonas");
            DropForeignKey("dbo.Sedes", "MunicipioId", "dbo.Municipios");
            DropForeignKey("dbo.Municipios", "DepartamentoId", "dbo.Departamentos");
            DropForeignKey("dbo.Sedes", "EspecialidadId", "dbo.Especialidades");
            DropForeignKey("dbo.Sedes", "DepartamentoId", "dbo.Departamentos");
            DropIndex("dbo.TipoAcademicos", new[] { "SedeId" });
            DropIndex("dbo.Periodos", new[] { "SedeId" });
            DropIndex("dbo.Materias", new[] { "SedeId" });
            DropIndex("dbo.Materias", new[] { "JornadaId" });
            DropIndex("dbo.Materias", new[] { "GrupoId" });
            DropIndex("dbo.Materias", new[] { "GradoId" });
            DropIndex("dbo.Materias", new[] { "ProfesorId" });
            DropIndex("dbo.Materias", new[] { "ClasificacionId" });
            DropIndex("dbo.Juicios", new[] { "SedeId" });
            DropIndex("dbo.Juicios", new[] { "PeriodoId" });
            DropIndex("dbo.Juicios", new[] { "MateriaId" });
            DropIndex("dbo.Juicios", new[] { "JornadaId" });
            DropIndex("dbo.Juicios", new[] { "GrupoId" });
            DropIndex("dbo.Juicios", new[] { "GradoId" });
            DropIndex("dbo.Nucleos", new[] { "MunicipioId" });
            DropIndex("dbo.Nucleos", new[] { "DepartamentoId" });
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
            DropIndex("dbo.EscalaNacionales", new[] { "SedeId" });
            DropIndex("dbo.ValoracionLetras", new[] { "SedeId" });
            DropIndex("dbo.Equivalencias", new[] { "SedeId" });
            DropIndex("dbo.Equivalencias", new[] { "ValoracionLetraId" });
            DropIndex("dbo.Profesores", new[] { "SedeId" });
            DropIndex("dbo.Profesores", new[] { "EscalafonId" });
            DropIndex("dbo.Profesores", new[] { "ProfesionId" });
            DropIndex("dbo.Profesores", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Jornadas", new[] { "SedeId" });
            DropIndex("dbo.Grupos", new[] { "SedeId" });
            DropIndex("dbo.Grados", new[] { "SedeId" });
            DropIndex("dbo.Cursos", new[] { "SedeId" });
            DropIndex("dbo.Cursos", new[] { "ProfesorId" });
            DropIndex("dbo.Cursos", new[] { "JornadaId" });
            DropIndex("dbo.Cursos", new[] { "GrupoId" });
            DropIndex("dbo.Cursos", new[] { "GradoId" });
            DropIndex("dbo.Municipios", new[] { "DepartamentoId" });
            DropIndex("dbo.Sedes", new[] { "EspecialidadId" });
            DropIndex("dbo.Sedes", new[] { "ZonaId" });
            DropIndex("dbo.Sedes", new[] { "MunicipioId" });
            DropIndex("dbo.Sedes", new[] { "DepartamentoId" });
            DropIndex("dbo.Asignaturas", new[] { "SedeId" });
            DropTable("dbo.TipoVinculaciones");
            DropTable("dbo.TipoRespuestas");
            DropTable("dbo.TipoDevengos");
            DropTable("dbo.TipoCondiciones");
            DropTable("dbo.TipoCaracteres");
            DropTable("dbo.TipoAcademicos");
            DropTable("dbo.SituacionAcademicas");
            DropTable("dbo.Sisbenes");
            DropTable("dbo.PoblacionVictimaConflictos");
            DropTable("dbo.Parentescos");
            DropTable("dbo.NivelEducativos");
            DropTable("dbo.NivelEducativoDocentes");
            DropTable("dbo.LibretaMilitares");
            DropTable("dbo.Periodos");
            DropTable("dbo.Clasificaciones");
            DropTable("dbo.Materias");
            DropTable("dbo.Juicios");
            DropTable("dbo.TipoSectorEducaciones");
            DropTable("dbo.TipoNovedades");
            DropTable("dbo.TipoDiscapacidades");
            DropTable("dbo.TarifaAnuales");
            DropTable("dbo.Resguardos");
            DropTable("dbo.RegimenCostos");
            DropTable("dbo.PropiedadJuridicas");
            DropTable("dbo.Prestadores");
            DropTable("dbo.Nucleos");
            DropTable("dbo.Metodologias");
            DropTable("dbo.Instituciones");
            DropTable("dbo.Idiomas");
            DropTable("dbo.Generos");
            DropTable("dbo.GeneroEstudiantes");
            DropTable("dbo.FuenteRecursos");
            DropTable("dbo.FactorRhs");
            DropTable("dbo.Etnias");
            DropTable("dbo.Estratos");
            DropTable("dbo.EstadoCiviles");
            DropTable("dbo.EscalaNacionales");
            DropTable("dbo.ValoracionLetras");
            DropTable("dbo.Equivalencias");
            DropTable("dbo.Eps");
            DropTable("dbo.TipoIdentificaciones");
            DropTable("dbo.Profesiones");
            DropTable("dbo.Escalafones");
            DropTable("dbo.Profesores");
            DropTable("dbo.Jornadas");
            DropTable("dbo.Grupos");
            DropTable("dbo.Grados");
            DropTable("dbo.Cursos");
            DropTable("dbo.ClasesFuncionarios");
            DropTable("dbo.Cargos");
            DropTable("dbo.CapacidadExcepcionales");
            DropTable("dbo.Calendarios");
            DropTable("dbo.AsociacionPrivadas");
            DropTable("dbo.Zonas");
            DropTable("dbo.Municipios");
            DropTable("dbo.Especialidades");
            DropTable("dbo.Departamentos");
            DropTable("dbo.Sedes");
            DropTable("dbo.Asignaturas");
            DropTable("dbo.Ars");
            DropTable("dbo.AporteParafiscales");
        }
    }
}
