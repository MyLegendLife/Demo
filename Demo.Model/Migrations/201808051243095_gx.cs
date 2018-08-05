namespace Demo.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Tel = c.String(),
                        Level = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        LastUpdatedTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        RecordDate = c.DateTime(nullable: false),
                        UserId = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        LastUpdatedTime = c.DateTime(),
                        User_Id = c.Guid(),
                        Customer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Tel = c.String(),
                        Level = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        LastUpdatedTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Records", "User_Id", "dbo.Users");
            DropIndex("dbo.Records", new[] { "Customer_Id" });
            DropIndex("dbo.Records", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Records");
            DropTable("dbo.Customers");
        }
    }
}
