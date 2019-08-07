using ArmyViewer.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArmyViewer.Web.Utilities;

namespace ArmyViewer.Web.Controllers
{
    public class BattleController : Controller
    {
        // GET: Battle
        public ActionResult Index()
        {
            //ApplicationDbContext context = new ApplicationDbContext();

            string newUrl = Battle.ProcessYouTubeLink("https://www.youtube.com/watch?v=9f_k7_P3-nA");

            BattleViewModel battle = new BattleViewModel
            {
                CreatorId = 1,
                CreatorName = "Andrew",
                CreatorYTProfile = "https://youtube.com/DudePerfect",
                Description = "Test description",
                Name = "Test Battle",
                YTLink = "https://www.youtube.com/watch?v=9f_k7_P3-nA"
            };

            return View(battle);
        }
    }
}