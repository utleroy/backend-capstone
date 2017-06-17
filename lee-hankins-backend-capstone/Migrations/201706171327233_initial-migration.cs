namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductionCharges",
                c => new
                    {
                        ProductionChargesId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ColorNumber = c.Int(nullable: false),
                        NumberPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SetUpCharges = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductionChargesId);
            
            DropTable("dbo.PrintCharges");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PrintCharges",
                c => new
                    {
                        PrintChargesId = c.Int(nullable: false, identity: true),
                        Quantities = c.Int(nullable: false),
                        ColorsToPrint = c.Int(nullable: false),
                        PricePer = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SetUp = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PrintChargesId);
            
            DropTable("dbo.ProductionCharges");
        }
    }
}
