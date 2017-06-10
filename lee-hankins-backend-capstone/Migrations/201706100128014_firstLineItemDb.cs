namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstLineItemDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        LineItemId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LineItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LineItems");
        }
    }
}
