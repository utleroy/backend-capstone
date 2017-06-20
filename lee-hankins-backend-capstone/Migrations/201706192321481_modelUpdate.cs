namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineItems", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Customer", c => c.Int(nullable: false));
            DropColumn("dbo.LineItems", "OrderId");
            DropColumn("dbo.Orders", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.LineItems", "OrderId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Customer");
            DropColumn("dbo.LineItems", "Order");
        }
    }
}
