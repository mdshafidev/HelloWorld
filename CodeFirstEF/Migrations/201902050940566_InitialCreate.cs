namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depts",
                c => new
                    {
                        DId = c.Int(nullable: false, identity: true),
                        DName = c.String(),
                        Date = c.DateTime(nullable: false),
                        DNameDescription = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        EName = c.String(),
                        Designation = c.String(),
                        Salary = c.Int(nullable: false),
                        DOJ = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.Depts");
        }
    }
}
