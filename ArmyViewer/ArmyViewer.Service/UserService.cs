using System.Linq;
using ArmyViewer.Data;
using ArmyViewer.Service.Utilities;

namespace ArmyViewer.Service
{
    public class UserService : BaseService<User>
    {
        public UserService(string userId) : base(userId) { }

        public UserService(string userId, BattleHubContext context) : base(userId, context) { }

        
            public virtual User GetByAspUserId(string id)
        {
            return Context.Set<User>().IsNotDeleted().FirstOrDefault(x => x.AspNetUserId == id);
        }

        public override void SaveProjection(ref User input, User output)
        {
            output.FirstName = input.FirstName;
            output.LastName = input.LastName;
            output.YouTubeUrl = input.YouTubeUrl;
            output.TwitchUrl = input.TwitchUrl;
        }
    }
}
