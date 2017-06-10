namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductionCharges1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductionCharges",
                c => new
                    {
                        ProductionChargesId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        OneColor = c.String(),
                        TwoColor = c.String(),
                        ThreeColor = c.String(),
                        FourColor = c.String(),
                        FiveColor = c.String(),
                        SixColor = c.String(),
                        SetUpCharges = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductionChargesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductionCharges");
        }
    }
}
