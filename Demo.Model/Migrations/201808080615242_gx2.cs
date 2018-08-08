namespace Demo.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gx2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Record", "User_Id", "dbo.User");
            DropForeignKey("dbo.Record", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.Record", new[] { "User_Id" });
            DropIndex("dbo.Record", new[] { "Customer_Id" });
            RenameColumn(table: "dbo.Record", name: "Customer_Id", newName: "CustomerId");
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Record", "CustomerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Record", "CustomerId");
            AddForeignKey("dbo.Record", "CustomerId", "dbo.Customer", "Id", cascadeDelete: true);
            DropColumn("dbo.Record", "UserId");
            DropColumn("dbo.Record", "User_Id");
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
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
            
            AddColumn("dbo.Record", "User_Id", c => c.Guid());
            AddColumn("dbo.Record", "UserId", c => c.String());
            DropForeignKey("dbo.Record", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Record", new[] { "CustomerId" });
            AlterColumn("dbo.Record", "CustomerId", c => c.Guid());
            AlterColumn("dbo.Customer", "Name", c => c.String());
            RenameColumn(table: "dbo.Record", name: "CustomerId", newName: "Customer_Id");
            CreateIndex("dbo.Record", "Customer_Id");
            CreateIndex("dbo.Record", "User_Id");
            AddForeignKey("dbo.Record", "Customer_Id", "dbo.Customer", "Id");
            AddForeignKey("dbo.Record", "User_Id", "dbo.User", "Id");
        }
    }
}
