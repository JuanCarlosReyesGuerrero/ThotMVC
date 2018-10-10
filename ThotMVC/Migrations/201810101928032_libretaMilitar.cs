namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class libretaMilitar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Juicios", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Materias", "JornadaId", "dbo.Jornadas");
            DropPrimaryKey("dbo.Jornadas");
            DropPrimaryKey("dbo.FuenteRecursos");
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

            DropColumn("dbo.Jornadas", "JornadaId");
            DropColumn("dbo.Jornadas", "JornadaCodigo");
            DropColumn("dbo.Jornadas", "JornadaNombre");
            DropColumn("dbo.FuenteRecursos", "FuenteRecursoId");
            DropColumn("dbo.FuenteRecursos", "FuenteRecursoCodigo");
            DropColumn("dbo.FuenteRecursos", "FuenteRecursoNombre");
            AddColumn("dbo.Grupos", "SedeId", c => c.Long(nullable: false));
            AddColumn("dbo.Jornadas", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Jornadas", "Codigo", c => c.String(nullable: false));
            AddColumn("dbo.Jornadas", "Nombre", c => c.String(nullable: false));
            AddColumn("dbo.FuenteRecursos", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.FuenteRecursos", "Codigo", c => c.String(nullable: false));
            AddColumn("dbo.FuenteRecursos", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Grados", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Grupos", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.GeneroEstudiantes", "Codigo", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Jornadas", "Id");
            AddPrimaryKey("dbo.FuenteRecursos", "Id");
            CreateIndex("dbo.Grupos", "SedeId");
            AddForeignKey("dbo.Grupos", "SedeId", "dbo.Sedes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Juicios", "JornadaId", "dbo.Jornadas", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Materias", "JornadaId", "dbo.Jornadas", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            AddColumn("dbo.FuenteRecursos", "FuenteRecursoNombre", c => c.String(nullable: false));
            AddColumn("dbo.FuenteRecursos", "FuenteRecursoCodigo", c => c.Long(nullable: false));
            AddColumn("dbo.FuenteRecursos", "FuenteRecursoId", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Jornadas", "JornadaNombre", c => c.String(nullable: false));
            AddColumn("dbo.Jornadas", "JornadaCodigo", c => c.String(nullable: false));
            AddColumn("dbo.Jornadas", "JornadaId", c => c.Long(nullable: false, identity: true));
            DropForeignKey("dbo.Materias", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Juicios", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas");
            DropForeignKey("dbo.Grupos", "SedeId", "dbo.Sedes");
            DropIndex("dbo.Grupos", new[] { "SedeId" });
            DropPrimaryKey("dbo.FuenteRecursos");
            DropPrimaryKey("dbo.Jornadas");
            AlterColumn("dbo.GeneroEstudiantes", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Grupos", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.Grados", "Codigo", c => c.Long(nullable: false));
            DropColumn("dbo.FuenteRecursos", "Nombre");
            DropColumn("dbo.FuenteRecursos", "Codigo");
            DropColumn("dbo.FuenteRecursos", "Id");
            DropColumn("dbo.Jornadas", "Nombre");
            DropColumn("dbo.Jornadas", "Codigo");
            DropColumn("dbo.Jornadas", "Id");
            DropColumn("dbo.Grupos", "SedeId");
            DropTable("dbo.LibretaMilitares");
            AddPrimaryKey("dbo.FuenteRecursos", "FuenteRecursoId");
            AddPrimaryKey("dbo.Jornadas", "JornadaId");
            AddForeignKey("dbo.Materias", "JornadaId", "dbo.Jornadas", "JornadaId", cascadeDelete: true);
            AddForeignKey("dbo.Juicios", "JornadaId", "dbo.Jornadas", "JornadaId", cascadeDelete: true);
            AddForeignKey("dbo.Cursos", "JornadaId", "dbo.Jornadas", "JornadaId", cascadeDelete: true);
        }
    }
}
