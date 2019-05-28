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
    public class RawMaterialsController : Controller
    {
        private Entities db = new Entities();

        // GET: RawMaterials
        public ActionResult Index()
        {
            return View(db.RawMaterials.ToList());
        }

        // GET: RawMaterials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RawMaterial rawMaterial = db.RawMaterials.Find(id);
            if (rawMaterial == null)
            {
                return HttpNotFound();
            }
            return View(rawMaterial);
        }

        // GET: RawMaterials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RawMaterials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RawMaterialID,RawMaterialName,RawMaterialStandardCost,RawMaterialUnitofMeasure")] RawMaterial rawMaterial)
        {
            if (ModelState.IsValid)
            {

                //sort the employee and get the last insert employee.
                var lastemployee = db.RawMaterials.OrderByDescending(c => c.RawMaterialID).FirstOrDefault();
                if (lastemployee == null)
                {
                    rawMaterial.RawMaterialID = 0;
                }
                else
                {
                    //using string substring method to get the number of the last inserted employee's EmployeeID 
                    rawMaterial.RawMaterialID = lastemployee.RawMaterialID + 1;
                }
                db.RawMaterials.Add(rawMaterial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rawMaterial);
        }

        // GET: RawMaterials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RawMaterial rawMaterial = db.RawMaterials.Find(id);
            if (rawMaterial == null)
            {
                return HttpNotFound();
            }
            return View(rawMaterial);
        }

        // POST: RawMaterials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RawMaterialID,RawMaterialName,RawMaterialStandardCost,RawMaterialUnitofMeasure")] RawMaterial rawMaterial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rawMaterial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rawMaterial);
        }

        // GET: RawMaterials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RawMaterial rawMaterial = db.RawMaterials.Find(id);
            if (rawMaterial == null)
            {
                return HttpNotFound();
            }
            return View(rawMaterial);
        }

        // POST: RawMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RawMaterial rawMaterial = db.RawMaterials.Find(id);
            db.RawMaterials.Remove(rawMaterial);
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
