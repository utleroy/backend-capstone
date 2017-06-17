namespace lee_hankins_backend_capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lineItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineItems", "ProductSelected", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LineItems", "ProductSelected");
        }
    }
}
