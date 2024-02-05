namespace TourTest.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddOrder : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTimeOffset(nullable: false, precision: 7),
                        AllSale = c.Int(nullable: false),
                        DateReceipt = c.DateTimeOffset(nullable: false, precision: 7),
                        ReceivingPointId = c.Int(nullable: false),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReceivingPoints", t => t.ReceivingPointId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ReceivingPointId);
            
            CreateTable(
                "dbo.ReceivingPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tours", "Order_Id", c => c.Int());
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Tours", "Order_Id");
            AddForeignKey("dbo.Tours", "Order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tours", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ReceivingPointId", "dbo.ReceivingPoints");
            DropIndex("dbo.Orders", new[] { "ReceivingPointId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Tours", new[] { "Order_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Tours", "Order_Id");
            DropTable("dbo.ReceivingPoints");
            DropTable("dbo.Orders");
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
