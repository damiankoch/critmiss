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
        public BattleService(int userId) : base(userId) { }

        public BattleService(int userId, BattleHubContext context) : base(userId, context) { }

        public override Battle SaveProjection(Battle input)
        {
            throw new NotImplementedException();
        }
    }
}
