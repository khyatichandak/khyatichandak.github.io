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
    public class EmployeeSkillsController : Controller
    {
        private Entities db = new Entities();

        // GET: EmployeeSkills
        public ActionResult Index()
        {
            return View(db.EmployeeSkills.ToList());
        }

        // GET: EmployeeSkills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
            if (employeeSkill == null)
            {
                return HttpNotFound();
            }
            return View(employeeSkill);
        }

        // GET: EmployeeSkills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeSkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeSkillID,EmployeeSkillName")] EmployeeSkill employeeSkill)
        {
            if (ModelState.IsValid)
            {

                //sort the employee and get the last insert employee.
                var lastemployee = db.EmployeeSkills.OrderByDescending(c => c.EmployeeSkillID).FirstOrDefault();
                if (lastemployee == null)
                {
                    employeeSkill.EmployeeSkillID = 0;
                }
                else
                {
                    //using string substring method to get the number of the last inserted employee's EmployeeID 
                    employeeSkill.EmployeeSkillID = lastemployee.EmployeeSkillID + 1;
                }
                db.EmployeeSkills.Add(employeeSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeSkill);
        }

        // GET: EmployeeSkills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
            if (employeeSkill == null)
            {
                return HttpNotFound();
            }
            return View(employeeSkill);
        }

        // POST: EmployeeSkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeSkillID,EmployeeSkillName")] EmployeeSkill employeeSkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeSkill);
        }

        // GET: EmployeeSkills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
            if (employeeSkill == null)
            {
                return HttpNotFound();
            }
            return View(employeeSkill);
        }

        // POST: EmployeeSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
            db.EmployeeSkills.Remove(employeeSkill);
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
