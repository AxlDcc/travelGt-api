namespace TravelUdeoBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateFiledHotelIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Regions", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Regions", "ImageUrl", c => c.Int(nullable: false));
        }
    }
}
