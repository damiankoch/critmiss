using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmyViewer.Web.Models
{
    public class BattleViewModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string YTLink { get; set; }
        public string CreatorName { get; set; }
        public string CreatorYTProfile { get; set; }
        public string CreatorId { get; set; }
        public string UserId { get; set; }
        public List<BattleTurnViewModel> Turns { get; set; }
    }
}