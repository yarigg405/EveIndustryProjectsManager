namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blueprints",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        CopyingTime = c.Int(nullable: false),
                        InventionTime = c.Int(nullable: false),
                        InventionProbability = c.Single(nullable: false),
                        InventionQuantity = c.Int(nullable: false),
                        ParentBlueprintId = c.String(),
                        ManufacturingTime = c.Int(nullable: false),
                        ManufacturingQuantity = c.Int(nullable: false),
                        ManufacturingItemId = c.String(maxLength: 128),
                        ResearchMaterialTime = c.Int(nullable: false),
                        ResearchTimeTime = c.Int(nullable: false),
                        ParentBlueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BlueprintId)
                .ForeignKey("dbo.Blueprints", t => t.ParentBlueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ManufacturingItemId)
                .Index(t => t.ManufacturingItemId)
                .Index(t => t.ParentBlueprint_BlueprintId);
            
            CreateTable(
                "dbo.CopyingItemsLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.ItemId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.BlueprintId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.ItemId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventionItemsLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.ItemId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.BlueprintId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.ItemId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.ItemsModernisations",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.ItemId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductionTime = c.Long(nullable: false),
                        ItemId = c.Int(nullable: false),
                        BlueprintsCount = c.Int(nullable: false),
                        ItemsCount = c.Int(nullable: false),
                        Item_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.ItemsProductions",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.ItemId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ManufacturingItemsLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.ItemId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.BlueprintId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.ItemId)
                .Index(t => t.Blueprint_BlueprintId);
            
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
                        SellVolume = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ResearchMaterialItemsLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.ItemId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.BlueprintId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.ItemId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.ResearchTimeItemsLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.ItemId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.BlueprintId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.ItemId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.CopyingSkillLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.SkillId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Skills", t => t.BlueprintId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Blueprints", t => t.SkillId)
                .Index(t => t.BlueprintId)
                .Index(t => t.SkillId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventionSkillLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.SkillId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.BlueprintId)
                .ForeignKey("dbo.Blueprints", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.SkillId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.ManufacturingSkillLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.SkillId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.BlueprintId)
                .ForeignKey("dbo.Blueprints", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.SkillId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.ResearchMaterialSkillLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.SkillId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.BlueprintId)
                .ForeignKey("dbo.Blueprints", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.SkillId)
                .Index(t => t.Blueprint_BlueprintId);
            
            CreateTable(
                "dbo.ResearchTimeSkillLists",
                c => new
                    {
                        BlueprintId = c.String(nullable: false, maxLength: 128),
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Blueprint_BlueprintId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BlueprintId, t.SkillId })
                .ForeignKey("dbo.Blueprints", t => t.Blueprint_BlueprintId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.BlueprintId)
                .ForeignKey("dbo.Blueprints", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.BlueprintId)
                .Index(t => t.SkillId)
                .Index(t => t.Blueprint_BlueprintId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResearchTimeSkillLists", "SkillId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchTimeItemsLists", "BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchMaterialSkillLists", "SkillId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchMaterialItemsLists", "BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ManufacturingSkillLists", "SkillId", "dbo.Blueprints");
            DropForeignKey("dbo.ManufacturingItemsLists", "BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.Blueprints", "ManufacturingItemId", "dbo.Items");
            DropForeignKey("dbo.InventionSkillLists", "SkillId", "dbo.Blueprints");
            DropForeignKey("dbo.InventionItemsLists", "BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.Blueprints", "ParentBlueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.CopyingSkillLists", "SkillId", "dbo.Blueprints");
            DropForeignKey("dbo.CopyingSkillLists", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.ResearchTimeSkillLists", "BlueprintId", "dbo.Skills");
            DropForeignKey("dbo.ResearchTimeSkillLists", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.ResearchTimeSkillLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchMaterialSkillLists", "BlueprintId", "dbo.Skills");
            DropForeignKey("dbo.ResearchMaterialSkillLists", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.ResearchMaterialSkillLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ManufacturingSkillLists", "BlueprintId", "dbo.Skills");
            DropForeignKey("dbo.ManufacturingSkillLists", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.ManufacturingSkillLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.InventionSkillLists", "BlueprintId", "dbo.Skills");
            DropForeignKey("dbo.InventionSkillLists", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.InventionSkillLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.CopyingSkillLists", "BlueprintId", "dbo.Skills");
            DropForeignKey("dbo.CopyingSkillLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.CopyingItemsLists", "BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchTimeItemsLists", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ResearchTimeItemsLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ResearchMaterialItemsLists", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ResearchMaterialItemsLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.Orders", "Id", "dbo.Items");
            DropForeignKey("dbo.ManufacturingItemsLists", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ManufacturingItemsLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.ItemsProductions", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ItemsProductions", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ItemId", "dbo.Items");
            DropForeignKey("dbo.InventionItemsLists", "ItemId", "dbo.Items");
            DropForeignKey("dbo.InventionItemsLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropForeignKey("dbo.CopyingItemsLists", "ItemId", "dbo.Items");
            DropForeignKey("dbo.CopyingItemsLists", "Blueprint_BlueprintId", "dbo.Blueprints");
            DropIndex("dbo.ResearchTimeSkillLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ResearchTimeSkillLists", new[] { "SkillId" });
            DropIndex("dbo.ResearchTimeSkillLists", new[] { "BlueprintId" });
            DropIndex("dbo.ResearchMaterialSkillLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ResearchMaterialSkillLists", new[] { "SkillId" });
            DropIndex("dbo.ResearchMaterialSkillLists", new[] { "BlueprintId" });
            DropIndex("dbo.ManufacturingSkillLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ManufacturingSkillLists", new[] { "SkillId" });
            DropIndex("dbo.ManufacturingSkillLists", new[] { "BlueprintId" });
            DropIndex("dbo.InventionSkillLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.InventionSkillLists", new[] { "SkillId" });
            DropIndex("dbo.InventionSkillLists", new[] { "BlueprintId" });
            DropIndex("dbo.CopyingSkillLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.CopyingSkillLists", new[] { "SkillId" });
            DropIndex("dbo.CopyingSkillLists", new[] { "BlueprintId" });
            DropIndex("dbo.ResearchTimeItemsLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ResearchTimeItemsLists", new[] { "ItemId" });
            DropIndex("dbo.ResearchTimeItemsLists", new[] { "BlueprintId" });
            DropIndex("dbo.ResearchMaterialItemsLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ResearchMaterialItemsLists", new[] { "ItemId" });
            DropIndex("dbo.ResearchMaterialItemsLists", new[] { "BlueprintId" });
            DropIndex("dbo.Orders", new[] { "Id" });
            DropIndex("dbo.ManufacturingItemsLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.ManufacturingItemsLists", new[] { "ItemId" });
            DropIndex("dbo.ManufacturingItemsLists", new[] { "BlueprintId" });
            DropIndex("dbo.ItemsProductions", new[] { "ItemId" });
            DropIndex("dbo.ItemsProductions", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "Item_Id" });
            DropIndex("dbo.ItemsModernisations", new[] { "ItemId" });
            DropIndex("dbo.ItemsModernisations", new[] { "ProjectId" });
            DropIndex("dbo.InventionItemsLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.InventionItemsLists", new[] { "ItemId" });
            DropIndex("dbo.InventionItemsLists", new[] { "BlueprintId" });
            DropIndex("dbo.CopyingItemsLists", new[] { "Blueprint_BlueprintId" });
            DropIndex("dbo.CopyingItemsLists", new[] { "ItemId" });
            DropIndex("dbo.CopyingItemsLists", new[] { "BlueprintId" });
            DropIndex("dbo.Blueprints", new[] { "ParentBlueprint_BlueprintId" });
            DropIndex("dbo.Blueprints", new[] { "ManufacturingItemId" });
            DropTable("dbo.ResearchTimeSkillLists");
            DropTable("dbo.ResearchMaterialSkillLists");
            DropTable("dbo.ManufacturingSkillLists");
            DropTable("dbo.InventionSkillLists");
            DropTable("dbo.Skills");
            DropTable("dbo.CopyingSkillLists");
            DropTable("dbo.ResearchTimeItemsLists");
            DropTable("dbo.ResearchMaterialItemsLists");
            DropTable("dbo.Orders");
            DropTable("dbo.ManufacturingItemsLists");
            DropTable("dbo.ItemsProductions");
            DropTable("dbo.Projects");
            DropTable("dbo.ItemsModernisations");
            DropTable("dbo.InventionItemsLists");
            DropTable("dbo.Items");
            DropTable("dbo.CopyingItemsLists");
            DropTable("dbo.Blueprints");
        }
    }
}
