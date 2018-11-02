namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Matriculas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstadoEstudiantes",
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
                "dbo.Matriculas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EstudianteId = c.Long(nullable: false),
                        EdadMatricula = c.String(),
                        NumeroMatricula = c.String(nullable: false),
                        Numerofolio = c.String(nullable: false),
                        FechaMatricula = c.DateTime(nullable: false),
                        AnioMatricula = c.DateTime(nullable: false),
                        GradoId = c.Long(nullable: false),
                        GrupoId = c.Long(nullable: false),
                        JornadaId = c.Long(nullable: false),
                        EstadoMatricula = c.Long(nullable: false),
                        Repitente = c.Boolean(nullable: false),
                        TipoCaracterId = c.Long(nullable: false),
                        SedeId = c.Long(nullable: false),
                        Observaciones = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EstadoEstudiantes", t => t.EstadoMatricula, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.EstudianteId, cascadeDelete: true)
                .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: true)
                .ForeignKey("dbo.Grupos", t => t.GrupoId, cascadeDelete: false)
                .ForeignKey("dbo.Jornadas", t => t.JornadaId, cascadeDelete: true)
                .ForeignKey("dbo.Sedes", t => t.SedeId, cascadeDelete: false)
                .ForeignKey("dbo.TipoCaracteres", t => t.TipoCaracterId, cascadeDelete: true)
                .Index(t => t.EstudianteId)
                .Index(t => t.GradoId)
                .Index(t => t.GrupoId)
                .Index(t => t.JornadaId)
                .Index(t => t.EstadoMatricula)
                .Index(t => t.TipoCaracterId)
                .Index(t => t.SedeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "TipoCaracterId", "dbo.TipoCaracteres");
            DropForeignKey("dbo.Matriculas", "SedeId", "dbo.Sedes");
            DropForeignKey("dbo.Matriculas", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Matriculas", "GrupoId", "dbo.Grupos");
            DropForeignKey("dbo.Matriculas", "GradoId", "dbo.Grados");
            DropForeignKey("dbo.Matriculas", "EstudianteId", "dbo.Estudiantes");
            DropForeignKey("dbo.Matriculas", "EstadoMatricula", "dbo.EstadoEstudiantes");
            DropIndex("dbo.Matriculas", new[] { "SedeId" });
            DropIndex("dbo.Matriculas", new[] { "TipoCaracterId" });
            DropIndex("dbo.Matriculas", new[] { "EstadoMatricula" });
            DropIndex("dbo.Matriculas", new[] { "JornadaId" });
            DropIndex("dbo.Matriculas", new[] { "GrupoId" });
            DropIndex("dbo.Matriculas", new[] { "GradoId" });
            DropIndex("dbo.Matriculas", new[] { "EstudianteId" });
            DropTable("dbo.Matriculas");
            DropTable("dbo.EstadoEstudiantes");
        }
    }
}
