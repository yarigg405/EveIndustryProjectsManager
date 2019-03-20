namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Manytomanyrelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemsModernisations", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.ItemsProductions", "Item_Id", "dbo.Items");
            DropIndex("dbo.ItemsModernisations", new[] { "Item_Id" });
            DropIndex("dbo.ItemsProductions", new[] { "Item_Id" });
            DropColumn("dbo.ItemsModernisations", "ItemId");
            DropColumn("dbo.ItemsProductions", "ItemId");
            RenameColumn(table: "dbo.ItemsModernisations", name: "Item_Id", newName: "ItemId");
            RenameColumn(table: "dbo.ItemsProductions", name: "Item_Id", newName: "ItemId");
            DropPrimaryKey("dbo.ItemsModernisations");
            DropPrimaryKey("dbo.ItemsProductions");
            AlterColumn("dbo.ItemsModernisations", "ItemId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ItemsModernisations", "ItemId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ItemsProductions", "ItemId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ItemsProductions", "ItemId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ItemsModernisations", new[] { "ProjectId", "ItemId" });
            AddPrimaryKey("dbo.ItemsProductions", new[] { "ProjectId", "ItemId" });
            CreateIndex("dbo.ItemsModernisations", "ItemId");
            CreateIndex("dbo.ItemsProductions", "ItemId");
            AddForeignKey("dbo.ItemsModernisations", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemsProductions", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsProductions", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ItemId", "dbo.Items");
            DropIndex("dbo.ItemsProductions", new[] { "ItemId" });
            DropIndex("dbo.ItemsModernisations", new[] { "ItemId" });
            DropPrimaryKey("dbo.ItemsProductions");
            DropPrimaryKey("dbo.ItemsModernisations");
            AlterColumn("dbo.ItemsProductions", "ItemId", c => c.String(maxLength: 128));
            AlterColumn("dbo.ItemsProductions", "ItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.ItemsModernisations", "ItemId", c => c.String(maxLength: 128));
            AlterColumn("dbo.ItemsModernisations", "ItemId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ItemsProductions", new[] { "ProjectId", "ItemId" });
            AddPrimaryKey("dbo.ItemsModernisations", new[] { "ProjectId", "ItemId" });
            RenameColumn(table: "dbo.ItemsProductions", name: "ItemId", newName: "Item_Id");
            RenameColumn(table: "dbo.ItemsModernisations", name: "ItemId", newName: "Item_Id");
            AddColumn("dbo.ItemsProductions", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.ItemsModernisations", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.ItemsProductions", "Item_Id");
            CreateIndex("dbo.ItemsModernisations", "Item_Id");
            AddForeignKey("dbo.ItemsProductions", "Item_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.ItemsModernisations", "Item_Id", "dbo.Items", "Id");
        }
    }
}
