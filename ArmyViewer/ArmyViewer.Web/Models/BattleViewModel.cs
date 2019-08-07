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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string YTLink { get; set; }
        public string CreatorName { get; set; }
        public string CreatorYTProfile { get; set; }
        public int CreatorId { get; set; }
        public int UserId { get; set; }
    }
}