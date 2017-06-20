namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineItems", "Order_OrderId", c => c.Int());
            AddColumn("dbo.Orders", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.LineItems", "Order_OrderId");
            CreateIndex("dbo.Orders", "Customer_CustomerId");
            AddForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.LineItems", "Order_OrderId", "dbo.Orders", "OrderId");
            DropColumn("dbo.LineItems", "Order");
            DropColumn("dbo.Orders", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Customer", c => c.Int(nullable: false));
            AddColumn("dbo.LineItems", "Order", c => c.Int(nullable: false));
            DropForeignKey("dbo.LineItems", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            DropIndex("dbo.LineItems", new[] { "Order_OrderId" });
            DropColumn("dbo.Orders", "Customer_CustomerId");
            DropColumn("dbo.LineItems", "Order_OrderId");
        }
    }
}
