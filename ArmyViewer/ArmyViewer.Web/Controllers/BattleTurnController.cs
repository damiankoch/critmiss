using ArmyViewer.Web.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ArmyViewer.Web.Controllers
{
    public class BattleTurnController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BattleTurn
        public ActionResult Index()
        {
            return View(db.BattleTurnViewModels.ToList());
        }

        // GET: BattleTurn/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleTurnViewModel battleTurnViewModel = db.BattleTurnViewModels.Find(id);
            if (battleTurnViewModel == null)
            {
                return HttpNotFound();
            }
            return View(battleTurnViewModel);
        }

        // GET: BattleTurn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BattleTurn/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BattleId,Description,TurnNumber")] BattleTurnViewModel battleTurnViewModel)
        {
            if (ModelState.IsValid)
            {
                db.BattleTurnViewModels.Add(battleTurnViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(battleTurnViewModel);
        }

        // GET: BattleTurn/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleTurnViewModel battleTurnViewModel = db.BattleTurnViewModels.Find(id);
            if (battleTurnViewModel == null)
            {
                return HttpNotFound();
            }
            return View(battleTurnViewModel);
        }

        // POST: BattleTurn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BattleId,Description,TurnNumber")] BattleTurnViewModel battleTurnViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(battleTurnViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(battleTurnViewModel);
        }

        // GET: BattleTurn/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleTurnViewModel battleTurnViewModel = db.BattleTurnViewModels.Find(id);
            if (battleTurnViewModel == null)
            {
                return HttpNotFound();
            }
            return View(battleTurnViewModel);
        }

        // POST: BattleTurn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BattleTurnViewModel battleTurnViewModel = db.BattleTurnViewModels.Find(id);
            db.BattleTurnViewModels.Remove(battleTurnViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
