namespace EveIndustry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcountofblueprints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "BlueprintsCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "BlueprintsCount");
        }
    }
}
