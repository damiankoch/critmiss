using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArmyViewer.Web.Models
{
    public class BattleTurnViewModel
    {
        [Key]
        public int Id { get; set; }
        public int BattleId { get; set; }
        public string Description { get; set; }
        public int TurnNumber { get; set; }
    }
}