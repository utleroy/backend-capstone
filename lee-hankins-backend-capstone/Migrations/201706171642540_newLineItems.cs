namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newLineItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineItems", "product", c => c.String());
            AddColumn("dbo.LineItems", "imprintPrice", c => c.Double(nullable: false));
            AddColumn("dbo.LineItems", "shirtPrice", c => c.Double(nullable: false));
            AddColumn("dbo.LineItems", "imprintTotal", c => c.Double(nullable: false));
            AddColumn("dbo.LineItems", "lineTotal", c => c.Double(nullable: false));
            DropColumn("dbo.LineItems", "ProductSelected");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LineItems", "ProductSelected", c => c.String());
            DropColumn("dbo.LineItems", "lineTotal");
            DropColumn("dbo.LineItems", "imprintTotal");
            DropColumn("dbo.LineItems", "shirtPrice");
            DropColumn("dbo.LineItems", "imprintPrice");
            DropColumn("dbo.LineItems", "product");
        }
    }
}
