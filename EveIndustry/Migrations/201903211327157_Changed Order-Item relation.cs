namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedOrderItemrelation : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Orders", new[] { "Item_Id" });
            DropColumn("dbo.Orders", "Id");
            RenameColumn(table: "dbo.Orders", name: "Item_Id", newName: "Id");
            DropPrimaryKey("dbo.Orders");
            AddColumn("dbo.Orders", "ItemId", c => c.String());
            AlterColumn("dbo.Orders", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Orders", "Id");
            CreateIndex("dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Orders", new[] { "Id" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Orders", "ItemId");
            AddPrimaryKey("dbo.Orders", "Id");
            RenameColumn(table: "dbo.Orders", name: "Id", newName: "Item_Id");
            AddColumn("dbo.Orders", "Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Orders", "Item_Id");
        }
    }
}
