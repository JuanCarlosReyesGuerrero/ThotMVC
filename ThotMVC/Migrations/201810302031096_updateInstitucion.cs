namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateInstitucion : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Instituciones", "JornadaCompletaId");
            DropColumn("dbo.Instituciones", "JornadaMananaId");
            DropColumn("dbo.Instituciones", "JornadaTardeId");
            DropColumn("dbo.Instituciones", "JornadaNocturnaId");
            DropColumn("dbo.Instituciones", "JornadaFinSemanaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instituciones", "JornadaFinSemanaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaNocturnaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaTardeId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaMananaId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instituciones", "JornadaCompletaId", c => c.Boolean(nullable: false));
        }
    }
}
