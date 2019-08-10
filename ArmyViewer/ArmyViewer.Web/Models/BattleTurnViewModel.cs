using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArmyViewer.Web.Models
{
    public class BattleTurnViewModel
    {
        [Key]
        public string Id { get; set; }
        public string BattleId { get; set; }
        [DisplayName("Turn number")]
        public int TurnNumber { get; set; }
        [DisplayName("YouTube timestamp")]
        public int YouTubeTimestamp { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public string HtmlRenderedDescription { get; set; }
    }
}