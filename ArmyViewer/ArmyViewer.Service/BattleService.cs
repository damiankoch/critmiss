using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyViewer.Data;

namespace ArmyViewer.Service
{
    public class BattleService : BaseService<Data.Battle>
    {
        public BattleService(string userId) : base(userId) { }

        public BattleService(string userId, BattleHubContext context) : base(userId, context) { }

        public override void SaveProjection(ref Battle input, Battle output)
        {
            throw new NotImplementedException();
        }
    }
}
