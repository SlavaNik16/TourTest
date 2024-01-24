namespace TourTest.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FullDB : DbMigration
    {
        public override void Up()
        {
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

            AddColumn("dbo.Hotels", "CountryCode", c => c.String(maxLength: 128));
            CreateIndex("dbo.Hotels", "CountryCode");
            AddForeignKey("dbo.Hotels", "CountryCode", "dbo.Countries", "Code");
        }

        public override void Down()
        {
            DropForeignKey("dbo.TypeTours", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Hotels", "CountryCode", "dbo.Countries");
            DropIndex("dbo.TypeTours", new[] { "Tour_Id" });
            DropIndex("dbo.TypeTours", new[] { "Type_Id" });
            DropIndex("dbo.Hotels", new[] { "CountryCode" });
            DropColumn("dbo.Hotels", "CountryCode");
            DropTable("dbo.TypeTours");
            DropTable("dbo.Types");
        }
    }
}
