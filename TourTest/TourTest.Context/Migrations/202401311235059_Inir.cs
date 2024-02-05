namespace TourTest.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Inir : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rank = c.Int(nullable: false),
                        CountryCode = c.String(maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryCode)
                .Index(t => t.CountryCode);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryCode = c.String(maxLength: 128),
                        TicketCount = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActual = c.Boolean(nullable: false),
                        Description = c.String(),
                        ImagePreview = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryCode)
                .Index(t => t.CountryCode);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Patronymic = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TourHotels",
                c => new
                    {
                        Tour_Id = c.Int(nullable: false),
                        Hotel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tour_Id, t.Hotel_Id })
                .ForeignKey("dbo.Tours", t => t.Tour_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Tour_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.TypeTours",
                c => new
                    {
                        Type_Id = c.Int(nullable: false),
                        Tour_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Type_Id, t.Tour_Id })
                .ForeignKey("dbo.Types", t => t.Type_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.Tour_Id, cascadeDelete: true)
                .Index(t => t.Type_Id)
                .Index(t => t.Tour_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TypeTours", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.TourHotels", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.TourHotels", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.Tours", "CountryCode", "dbo.Countries");
            DropForeignKey("dbo.Hotels", "CountryCode", "dbo.Countries");
            DropIndex("dbo.TypeTours", new[] { "Tour_Id" });
            DropIndex("dbo.TypeTours", new[] { "Type_Id" });
            DropIndex("dbo.TourHotels", new[] { "Hotel_Id" });
            DropIndex("dbo.TourHotels", new[] { "Tour_Id" });
            DropIndex("dbo.Tours", new[] { "CountryCode" });
            DropIndex("dbo.Hotels", new[] { "CountryCode" });
            DropTable("dbo.TypeTours");
            DropTable("dbo.TourHotels");
            DropTable("dbo.Users");
            DropTable("dbo.Types");
            DropTable("dbo.Tours");
            DropTable("dbo.Hotels");
            DropTable("dbo.Countries");
        }
    }
}
