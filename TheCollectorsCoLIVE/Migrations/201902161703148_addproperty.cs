namespace TheCollectorsCoLIVE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Done");
        }
    }
}
