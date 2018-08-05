namespace Demo.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gx1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Records", newName: "Record");
            RenameTable(name: "dbo.Users", newName: "User");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Record", newName: "Records");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
