namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedorderstable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SellVolume", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "SetllVolume");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "SetllVolume", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "SellVolume");
        }
    }
}
