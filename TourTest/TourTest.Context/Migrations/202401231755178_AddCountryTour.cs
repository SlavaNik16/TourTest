﻿namespace TourTest.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCountryTour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "CountryCode", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tours", "CountryCode");
            AddForeignKey("dbo.Tours", "CountryCode", "dbo.Countries", "Code");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Tours", "CountryCode", "dbo.Countries");
            DropIndex("dbo.Tours", new[] { "CountryCode" });
            DropColumn("dbo.Tours", "CountryCode");
        }
    }
}
