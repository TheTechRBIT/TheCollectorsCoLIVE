using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheCollectorsCoLIVE.Models;

namespace TheCollectorsCoLIVE.Migrations
{
    public class BaseballCard
    {
        [Key]
        public int BaseballCardID { get; set; }
        public string CardNumber { get; set; }
        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
        public int? PlayerID { get; set; }
        public virtual Player Player { get; set; }
        public int? CoachID { get; set; }
        public virtual Coach Coach { get; set; }
        public int? PositionID { get; set; }
        public virtual Position Position { get; set; }
        public int PlayerNumber { get; set; }
        public int? ManufacturerID { get; set; }
        public virtual ManufacturerInfo ManufacturerInfo { get; set; }
        public int CardYear { get; set; }
        public string CardComments { get; set; }
        public string CardImage { get; set; }
         }
}