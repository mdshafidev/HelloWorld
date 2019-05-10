namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M0502191 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Dept_DId", c => c.Int());
            CreateIndex("dbo.Employees", "Dept_DId");
            AddForeignKey("dbo.Employees", "Dept_DId", "dbo.Depts", "DId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Dept_DId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "Dept_DId" });
            DropColumn("dbo.Employees", "Dept_DId");
        }
    }
}
