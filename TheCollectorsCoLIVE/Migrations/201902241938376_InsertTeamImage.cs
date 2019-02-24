namespace TheCollectorsCoLIVE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertTeamImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "TeamImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "TeamImageURL");
        }
    }
}
