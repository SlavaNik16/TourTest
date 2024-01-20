namespace TourTest.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tours", "ImagePreview", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tours", "ImagePreview");
        }
    }
}
