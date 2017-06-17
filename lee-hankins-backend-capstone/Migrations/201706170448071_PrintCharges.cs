namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrintCharges : DbMigration
    {
        public int Quantities { get; internal set; }
        public int ColorsToPrint { get; internal set; }
        public string PricePer { get; internal set; }
        public string Setup { get; internal set; }

        public override void Up()
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
            
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductionCharges",
                c => new
                    {
                        ProductionChargesId = c.Int(nullable: false, identity: true),
                        Quantities = c.Int(nullable: false),
                        ColorsToPrint = c.Int(nullable: false),
                        PricePer = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SetUp = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductionChargesId);
            
            DropTable("dbo.PrintCharges");
        }
    }
}
