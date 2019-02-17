using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheCollectorsCoLIVE.Migrations;

namespace TheCollectorsCoLIVE.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public virtual List<BaseballCard> BaseballCard { get; set; }
    }
}