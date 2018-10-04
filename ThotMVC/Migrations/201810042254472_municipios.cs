namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class municipios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Municipalities",
                c => new
                    {
                        MunicipalityId = c.Long(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        UnifiedCode = c.String(nullable: false),
                        DepartmentId = c.Long(nullable: false),
                        DepartmentCode = c.String(),
                        Status = c.Boolean(nullable: false),
                        UserRegister = c.Long(),
                        RegistrationDate = c.DateTime(),
                        UserModifies = c.Long(),
                        DateModifies = c.DateTime(),
                    })
                .PrimaryKey(t => t.MunicipalityId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipalities", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Municipalities", new[] { "DepartmentId" });
            DropTable("dbo.Municipalities");
        }
    }
}
