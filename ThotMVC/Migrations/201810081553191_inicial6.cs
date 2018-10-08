namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FactorRhs",
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
                "dbo.GeneroEstudiantes",
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
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
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
                .ForeignKey("dbo.Clasificaciones", t => t.ClasificacionId, cascadeDelete: true)
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
                "dbo.NivelEducativoDocentes",
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
                "dbo.NivelEducativos",
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
                "dbo.Parentescos",
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
                "dbo.TipoDevengos",
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
                "dbo.TipoVinculaciones",
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
            DropTable("dbo.TipoVinculaciones");
            DropTable("dbo.TipoDevengos");
            DropTable("dbo.TipoAcademicos");
            DropTable("dbo.Parentescos");
            DropTable("dbo.NivelEducativos");
            DropTable("dbo.NivelEducativoDocentes");
            DropTable("dbo.Periodos");
            DropTable("dbo.Clasificaciones");
            DropTable("dbo.Materias");
            DropTable("dbo.Juicios");
            DropTable("dbo.GeneroEstudiantes");
            DropTable("dbo.FactorRhs");
        }
    }
}
