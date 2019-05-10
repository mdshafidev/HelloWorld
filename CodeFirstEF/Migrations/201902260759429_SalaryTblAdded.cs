namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalaryTblAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalarForMonth = c.Int(nullable: false),
                        Employees_EId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_EId)
                .Index(t => t.Employees_EId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "Employees_EId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "Employees_EId" });
            DropTable("dbo.Salaries");
        }
    }
}
