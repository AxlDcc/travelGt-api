namespace TravelUdeoBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        UrlImg = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Category_Id = c.Int(),
                        Region_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Region_Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Locations", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Locations", new[] { "Region_Id" });
            DropIndex("dbo.Locations", new[] { "Category_Id" });
            DropTable("dbo.Regions");
            DropTable("dbo.Locations");
            DropTable("dbo.Categories");
        }
    }
}
