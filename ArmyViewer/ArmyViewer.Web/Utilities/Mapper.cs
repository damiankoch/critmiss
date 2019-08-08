using ArmyViewer.Data;
using ArmyViewer.Service;
using ArmyViewer.Web.Models;

namespace ArmyViewer.Web.Utilities
{
    public static class Mapper
    {
        #region Battle

        public static BattleViewModel ToViewModel(this Battle model)
        {
            var viewModel = new BattleViewModel();
            if (model == null) return viewModel;

            var userId = Account.GetUserId();
            var user = new UserService(userId).GetByAspUserId(model.CreatedBy);

            viewModel.CreatorId = model.CreatedBy;
            viewModel.CreatorName = $"{user.FirstName} {user.LastName}";
            viewModel.CreatorYTProfile = user.YouTubeUrl;
            viewModel.Description = model.Description;
            viewModel.Name = model.Name;
            viewModel.Id = model.Id;
            viewModel.UserId = model.CreatedBy;
            viewModel.YouTubeUrl = model.YouTubeUrl;

            return viewModel;
        }

        public static Battle ToDataModel(this BattleViewModel viewModel)
        {
            var dataModel = new Battle
            {
                Description = viewModel.Description,
                Name = viewModel.Name,
                YouTubeUrl = viewModel.YouTubeUrl
            };

            return dataModel;
        }

        #endregion
    }
}