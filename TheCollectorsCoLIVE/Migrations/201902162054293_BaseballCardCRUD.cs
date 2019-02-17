namespace TheCollectorsCoLIVE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseballCardCRUD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseballCards",
                c => new
                    {
                        BaseballCardID = c.Int(nullable: false, identity: true),
                        CardNumber = c.String(),
                        TeamID = c.Int(nullable: false),
                        PlayerID = c.Int(),
                        CoachID = c.Int(),
                        PositionID = c.Int(),
                        PlayerNumber = c.Int(nullable: false),
                        ManufacturerID = c.Int(),
                        CardYear = c.Int(nullable: false),
                        CardComments = c.String(),
                        CardImage = c.String(),
                    })
                .PrimaryKey(t => t.BaseballCardID)
                .ForeignKey("dbo.Coaches", t => t.CoachID)
                .ForeignKey("dbo.ManufacturerInfoes", t => t.ManufacturerID)
                .ForeignKey("dbo.Players", t => t.PlayerID)
                .ForeignKey("dbo.Positions", t => t.PositionID)
                .ForeignKey("dbo.Teams", t => t.TeamID, cascadeDelete: true)
                .Index(t => t.TeamID)
                .Index(t => t.PlayerID)
                .Index(t => t.CoachID)
                .Index(t => t.PositionID)
                .Index(t => t.ManufacturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaseballCards", "TeamID", "dbo.Teams");
            DropForeignKey("dbo.BaseballCards", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.BaseballCards", "PlayerID", "dbo.Players");
            DropForeignKey("dbo.BaseballCards", "ManufacturerID", "dbo.ManufacturerInfoes");
            DropForeignKey("dbo.BaseballCards", "CoachID", "dbo.Coaches");
            DropIndex("dbo.BaseballCards", new[] { "ManufacturerID" });
            DropIndex("dbo.BaseballCards", new[] { "PositionID" });
            DropIndex("dbo.BaseballCards", new[] { "CoachID" });
            DropIndex("dbo.BaseballCards", new[] { "PlayerID" });
            DropIndex("dbo.BaseballCards", new[] { "TeamID" });
            DropTable("dbo.BaseballCards");
        }
    }
}
