using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using S1G6_PVFAPP.Models;

namespace S1G6_PVFAPP.Controllers
{
    public class TerritoriesController : Controller
    {
        private Entities db = new Entities();

        // GET: Territories
        public ActionResult Index()
        {
            return View(db.Territories.ToList());
        }

        // GET: Territories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territory territory = db.Territories.Find(id);
            if (territory == null)
            {
                return HttpNotFound();
            }
            return View(territory);
        }

        // GET: Territories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Territories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TerritoryID,TerritoryName")] Territory territory)
        {
            if (ModelState.IsValid)
            {
                db.Territories.Add(territory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(territory);
        }

        // GET: Territories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territory territory = db.Territories.Find(id);
            if (territory == null)
            {
                return HttpNotFound();
            }
            return View(territory);
        }

        // POST: Territories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TerritoryID,TerritoryName")] Territory territory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(territory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(territory);
        }

        // GET: Territories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territory territory = db.Territories.Find(id);
            if (territory == null)
            {
                return HttpNotFound();
            }
            return View(territory);
        }

        // POST: Territories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Territory territory = db.Territories.Find(id);
            db.Territories.Remove(territory);
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
