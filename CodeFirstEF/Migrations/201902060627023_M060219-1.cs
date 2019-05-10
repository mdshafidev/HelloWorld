namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M0602191 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressName = c.String(),
                        PIN = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Addresses_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Addresses_Id");
            AddForeignKey("dbo.Employees", "Addresses_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Addresses_Id", "dbo.Addresses");
            DropIndex("dbo.Employees", new[] { "Addresses_Id" });
            DropColumn("dbo.Employees", "Addresses_Id");
            DropTable("dbo.Addresses");
        }
    }
}
