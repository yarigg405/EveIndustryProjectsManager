namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        ItemsCount = c.Int(nullable: false),
                        ExitItem_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ExitItem_Id)
                .Index(t => t.ExitItem_Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsProductions", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ItemsProductions", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ExitItem_Id", "dbo.Items");
            DropForeignKey("dbo.ItemsModernisations", "ItemId", "dbo.Items");
            DropIndex("dbo.ItemsProductions", new[] { "ItemId" });
            DropIndex("dbo.ItemsProductions", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "ExitItem_Id" });
            DropIndex("dbo.ItemsModernisations", new[] { "ItemId" });
            DropIndex("dbo.ItemsModernisations", new[] { "ProjectId" });
            DropTable("dbo.ItemsProductions");
            DropTable("dbo.Projects");
            DropTable("dbo.ItemsModernisations");
            DropTable("dbo.Items");
        }
    }
}
