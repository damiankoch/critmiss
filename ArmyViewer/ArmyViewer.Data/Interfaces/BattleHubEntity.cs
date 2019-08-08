using System;

namespace ArmyViewer.Data.Interfaces
{
    public interface IBattleHubEntity
    {
        string Id { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
        string DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }
        int Status { get; set; }
    }
}
