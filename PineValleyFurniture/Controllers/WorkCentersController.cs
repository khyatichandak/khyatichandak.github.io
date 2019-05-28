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
    public class WorkCentersController : Controller
    {
        private Entities db = new Entities();

        // GET: WorkCenters
        public ActionResult Index()
        {
            return View(db.WorkCenters.ToList());
        }

        // GET: WorkCenters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkCenter workCenter = db.WorkCenters.Find(id);
            if (workCenter == null)
            {
                return HttpNotFound();
            }
            return View(workCenter);
        }

        // GET: WorkCenters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkCenters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkCenterID,WorkCenterLocation")] WorkCenter workCenter)
        {
            if (ModelState.IsValid)
            {
                db.WorkCenters.Add(workCenter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workCenter);
        }

        // GET: WorkCenters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkCenter workCenter = db.WorkCenters.Find(id);
            if (workCenter == null)
            {
                return HttpNotFound();
            }
            return View(workCenter);
        }

        // POST: WorkCenters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkCenterID,WorkCenterLocation")] WorkCenter workCenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workCenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workCenter);
        }

        // GET: WorkCenters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkCenter workCenter = db.WorkCenters.Find(id);
            if (workCenter == null)
            {
                return HttpNotFound();
            }
            return View(workCenter);
        }

        // POST: WorkCenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkCenter workCenter = db.WorkCenters.Find(id);
            db.WorkCenters.Remove(workCenter);
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
