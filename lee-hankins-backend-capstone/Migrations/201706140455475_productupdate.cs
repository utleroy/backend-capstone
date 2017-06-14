namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "salePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "salePrice", c => c.Int(nullable: false));
        }
    }
}
