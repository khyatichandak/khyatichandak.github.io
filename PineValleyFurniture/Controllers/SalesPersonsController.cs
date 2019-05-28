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
    public class SalesPersonsController : Controller
    {
        private Entities db = new Entities();

        // GET: SalesPersons
        /*public ActionResult Index()
        {
            var salesPersons = db.SalesPersons.Include(s => s.SalesPerson1).Include(s => s.SalesPerson2).Include(s => s.Territory);
            return View(salesPersons.ToList());
        }*/

        public ActionResult Index(string sortSalesPerson)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortSalesPerson) ? "name_desc" : "";
            // ViewBag.SupervisorParm = sortOrder == "supervisor" ? "super_desc" : "super";
            var emp = from s in db.SalesPersons
                      select s;
            switch (sortSalesPerson)
            {
                case "name_desc":
                    emp = db.SalesPersons.OrderByDescending(s => s.SalesPersonName);
                    break;
                default:
                    emp = db.SalesPersons.OrderBy(s => s.SalesPersonName);
                    break;
            }
            return View(emp.ToList());

        }

        // GET: SalesPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPersons.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            return View(salesPerson);
        }

        // GET: SalesPersons/Create
        public ActionResult Create()
        {
            //ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName");
            //ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName");
            //ViewBag.TerritoryID = new SelectList(db.Territories, "TerritoryID", "TerritoryName");
            return View();
        }

        // POST: SalesPersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalesPersonID,SalesPersonName,SalesPersonPhone,SalesPersonEmailID,TerritoryID")] SalesPerson salesPerson)
        {
            if (ModelState.IsValid)
            {
                db.SalesPersons.Add(salesPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            //ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            //ViewBag.TerritoryID = new SelectList(db.Territories, "TerritoryID", "TerritoryName", salesPerson.TerritoryID);
            return View(salesPerson);
        }

        // GET: SalesPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPersons.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            ViewBag.TerritoryID = new SelectList(db.Territories, "TerritoryID", "TerritoryName", salesPerson.TerritoryID);
            return View(salesPerson);
        }

        // POST: SalesPersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalesPersonID,SalesPersonName,SalesPersonPhone,SalesPersonEmailID,TerritoryID")] SalesPerson salesPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "SalesPersonID", "SalesPersonName", salesPerson.SalesPersonID);
            ViewBag.TerritoryID = new SelectList(db.Territories, "TerritoryID", "TerritoryName", salesPerson.TerritoryID);
            return View(salesPerson);
        }

        // GET: SalesPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPersons.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            return View(salesPerson);
        }

        // POST: SalesPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesPerson salesPerson = db.SalesPersons.Find(id);
            db.SalesPersons.Remove(salesPerson);
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
