namespace TourTest.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
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
                    Description = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Tours",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TicketCount = c.Int(nullable: false),
                    Name = c.String(),
                    Description = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IsActual = c.Boolean(nullable: false),
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

        }

        public override void Down()
        {
            DropForeignKey("dbo.TourHotels", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.TourHotels", "Tour_Id", "dbo.Tours");
            DropIndex("dbo.TourHotels", new[] { "Hotel_Id" });
            DropIndex("dbo.TourHotels", new[] { "Tour_Id" });
            DropTable("dbo.TourHotels");
            DropTable("dbo.Tours");
            DropTable("dbo.Hotels");
            DropTable("dbo.Countries");
        }
    }
}
