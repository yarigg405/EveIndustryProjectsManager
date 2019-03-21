namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedorderstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BuyMaxJita = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyMinJita = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyVolume = c.Int(nullable: false),
                        SellMaxJita = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellMinJita = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SetllVolume = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        Item_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .Index(t => t.Item_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Item_Id", "dbo.Items");
            DropIndex("dbo.Orders", new[] { "Item_Id" });
            DropTable("dbo.Orders");
        }
    }
}
