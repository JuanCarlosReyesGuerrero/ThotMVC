namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateARS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ars", "Codigo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ars", "Codigo", c => c.Long(nullable: false));
        }
    }
}
