using ArmyViewer.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArmyViewer.Web.Utilities;
using ArmyViewer.Service;
using ArmyViewer.Data;

namespace ArmyViewer.Web.Controllers
{
    public class BattleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Battle
        public ActionResult Index(string Id)
        {
            if (Id == "")
            {
                string newUrl = Utilities.Utilities.ProcessYouTubeLink("https://www.youtube.com/watch?v=9f_k7_P3-nA");


                BattleViewModel viewModel = new BattleViewModel
                {
                    CreatorId = "",
                    CreatorName = "Andrew",
                    CreatorYTProfile = "https://youtube.com/DudePerfect",
                    Description = "Test description",
                    Name = "Test Battle",
                    YouTubeUrl = newUrl
                };

                return View(viewModel);
            }

            var battle = new BattleService(Account.GetUserId()).GetById(Id);

            if (battle != null)
            {
                return View(battle.ToViewModel());
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BattleViewModel newBattle)
        {
            if (ModelState.IsValid)
            {
                var svc = new BattleService(Account.GetUserId());
                svc.Insert(Mapper.ToDataModel(newBattle));

                return RedirectToAction("Index");
            }
            else
            {
                return View(newBattle);
            }
        }
    }
}