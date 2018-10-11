namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Municipio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipios", "DepartamentoCodigo", c => c.String());
            DropColumn("dbo.Municipios", "DepartamentoCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Municipios", "DepartamentoCode", c => c.String());
            DropColumn("dbo.Municipios", "DepartamentoCodigo");
        }
    }
}
