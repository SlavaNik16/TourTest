namespace TourTest.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGeneratedNone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types");
            DropPrimaryKey("dbo.Types");
            AlterColumn("dbo.Types", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Types", "Id");
            AddForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types");
            DropPrimaryKey("dbo.Types");
            AlterColumn("dbo.Types", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Types", "Id");
            AddForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
        }
    }
}
