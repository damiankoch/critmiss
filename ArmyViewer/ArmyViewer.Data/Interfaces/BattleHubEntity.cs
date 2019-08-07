using System;

namespace ArmyViewer.Data.Interfaces
{
    public interface IBattleHubEntity
    {
        int Id { get; set; }
        int CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        int? ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
        int? DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }
        int Status { get; set; }
    }
}
