namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstProductMigration : DbMigration
    {
        public override void Up()
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
                        salePrice = c.Int(nullable: false),
                        customerPrice = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
