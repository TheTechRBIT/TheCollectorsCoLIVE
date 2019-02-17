using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class TheCollectorsCoContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public TheCollectorsCoContext() : base("name=TheCollectorsCoContext")
    {
    }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Models.Player> Player { get; set; }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Models.Team> Team { get; set; }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Models.Position> Position { get; set; }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Models.ManufacturerInfo> ManufacturerInfo { get; set; }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Models.Coach> Coach { get; set; }

    public System.Data.Entity.DbSet<TheCollectorsCoLIVE.Migrations.BaseballCard> BaseballCard { get; set; }
}
