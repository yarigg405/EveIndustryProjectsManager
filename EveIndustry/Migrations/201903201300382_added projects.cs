namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprojects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductionTime = c.Long(nullable: false),
                        ItemsCount = c.Int(nullable: false),
                        ExitItem_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ExitItem_Id)
                .Index(t => t.ExitItem_Id);
            
            CreateTable(
                "dbo.ItemsModernisations",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Item_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.ItemId })
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.ItemsProductions",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Item_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.ItemId })
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.Item_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsProductions", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ItemsProductions", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ItemsModernisations", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Projects", "ExitItem_Id", "dbo.Items");
            DropIndex("dbo.ItemsProductions", new[] { "Item_Id" });
            DropIndex("dbo.ItemsProductions", new[] { "ProjectId" });
            DropIndex("dbo.ItemsModernisations", new[] { "Item_Id" });
            DropIndex("dbo.ItemsModernisations", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "ExitItem_Id" });
            DropTable("dbo.ItemsProductions");
            DropTable("dbo.ItemsModernisations");
            DropTable("dbo.Projects");
        }
    }
}
