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
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Battle
        public ActionResult Index(string Id)
        {
            if(Id == "")
            {
                string newUrl = Utilities.Utilities.ProcessYouTubeLink("https://www.youtube.com/watch?v=9f_k7_P3-nA");

            string newUrl = Battle.ProcessYouTubeLink("https://www.youtube.com/watch?v=9f_k7_P3-nA");

            BattleViewModel battle = new BattleViewModel
            {
                CreatorId = 1,
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

        //    BattleViewModel battle = new BattleViewModel
        //    {
        //        CreatorId = 1,
        //        CreatorName = "Andrew",
        //        CreatorYTProfile = "https://youtube.com/DudePerfect",
        //        Description = "Test description",
        //        Name = "Test Battle",
        //        YTLink = newUrl
        //    };

        //    return View(battle);
        //}

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BattleViewModel newBattle)
        {
            if (ModelState.IsValid)
            {
                db.BattleViewModels.Add(newBattle);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newBattle);
            }
        }
    }
}