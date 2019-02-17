using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheCollectorsCoLIVE.Migrations;

namespace TheCollectorsCoLIVE.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public virtual List<BaseballCard> BaseballCard { get; set; }
        public bool Done { get; set; }
    }
}