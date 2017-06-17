namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newLineItems1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineItems", "quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LineItems", "quantity");
        }
    }
}
