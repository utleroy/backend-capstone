namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeProduct : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        styleName = c.String(),
                        colorName = c.String(),
                        colorSwatchImage = c.String(),
                        colorSwatchTextColor = c.String(),
                        colorFrontImage = c.String(),
                        colorBackImage = c.String(),
                        sizeName = c.String(),
                        unitWeight = c.Int(nullable: false),
                        salePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        customerPrice = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
    }
}
