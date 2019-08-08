using ArmyViewer.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArmyViewer.Web.Utilities;
using ArmyViewer.Service;

namespace ArmyViewer.Web.Controllers
{
    public class BattleController : Controller
    {
        // GET: Battle
        public ActionResult Index(string Id)
        {
            if(Id == "")
            {
                string newUrl = Utilities.Utilities.ProcessYouTubeLink("https://www.youtube.com/watch?v=9f_k7_P3-nA");

                BattleViewModel viewModel = new BattleViewModel
                {
                    CreatorId = "fdsafsdfasdfsad",
                    CreatorName = "Andrew",
                    CreatorYTProfile = "https://youtube.com/DudePerfect",
                    Description = "Test description",
                    Name = "Test Battle",
                    YTLink = newUrl
                };

                return View(viewModel);
            }

            var battle = new BattleService(Account.GetUserId()).GetById(Id);

            if(battle != null)
            {
                return View(battle.ToViewModel());
            }

            return RedirectToAction("Index", "Home");
        }
    }
}