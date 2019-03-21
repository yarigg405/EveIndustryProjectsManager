namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedProjectsitem : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Projects", name: "ExitItem_Id", newName: "Item_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_ExitItem_Id", newName: "IX_Item_Id");
            AddColumn("dbo.Projects", "ItemId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "ItemId");
            RenameIndex(table: "dbo.Projects", name: "IX_Item_Id", newName: "IX_ExitItem_Id");
            RenameColumn(table: "dbo.Projects", name: "Item_Id", newName: "ExitItem_Id");
        }
    }
}
