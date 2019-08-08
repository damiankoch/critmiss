using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArmyViewer.Web.Models
{
    public class BattleTurnViewModel
    {
        [Key]
        public string Id { get; set; }
        public int BattleId { get; set; }
        public string Description { get; set; }
        public string HtmlRenderedDescription { get; set; }
        public int TurnNumber { get; set; }
    }
}