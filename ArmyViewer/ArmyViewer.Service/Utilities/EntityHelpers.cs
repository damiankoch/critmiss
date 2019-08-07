using ArmyViewer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyViewer.Service.Utilities
{
    public static class EntityHelpers
    {
        public static IEnumerable<T> IsNotDeleted<T>(this IEnumerable<T> input) where T: class, IBattleHubEntity
        {
            return input.Where(x => x.Status == 1);
        }
    }
}
