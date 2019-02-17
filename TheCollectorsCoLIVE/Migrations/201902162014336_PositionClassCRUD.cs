namespace TheCollectorsCoLIVE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PositionClassCRUD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Positions");
        }
    }
}
