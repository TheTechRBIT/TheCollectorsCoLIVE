namespace TheCollectorsCoLIVE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManufacturerClassCRUD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManufacturerInfoes",
                c => new
                    {
                        ManufacturerID = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManufacturerInfoes");
        }
    }
}
