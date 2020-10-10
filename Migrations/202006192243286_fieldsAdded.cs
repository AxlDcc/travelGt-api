namespace TravelUdeoBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fieldsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Views", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "isPopular", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "isPopular");
            DropColumn("dbo.Locations", "Views");
        }
    }
}
