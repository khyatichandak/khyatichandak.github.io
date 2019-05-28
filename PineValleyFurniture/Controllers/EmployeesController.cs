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
    public class EmployeesController : Controller
    {
        private Entities db = new Entities();

        // GET: Employees
        /*public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }*/

        public ActionResult Index(string sortOrder, String searchString)
        {
            if ((searchString == null || searchString == ""))
            {
                ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewBag.SupervisorParm = sortOrder == "supervisor" ? "super_desc" : "super";
                var emp = from s in db.Employees
                          select s;
                switch (sortOrder)
                {
                    case "name_desc":
                        emp = db.Employees.OrderByDescending(s => s.EmployeeName);
                        break;
                    case "super":
                        emp = db.Employees.OrderBy(s => s.SupervisorID);
                        break;
                    case "super_desc":
                        emp = db.Employees.OrderByDescending(s => s.SupervisorID);
                        break;
                    default:
                        emp = db.Employees.OrderBy(s => s.EmployeeName);
                        break;
                }
                return View(emp.ToList());
            }
            else
            {
                return View(db.Employees.Where(x => x.EmployeeName == searchString).ToList());
            }
        }


        /*public ActionResult Index(String searchString)
        {
            if (searchString == null || searchString == "")
            {
                return View(db.Employees.ToList());
            }
            else
            {
                return View(db.Employees.Where(x => x.EmployeeName == searchString).ToList());
            }
        }*/

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,EmployeeName,EmployeeAddress,EmployeePhone,EmployeeEmailID,EmployeeGender,EmployeeDesignation,SupervisorID")] Employee employee)
        {
            if (ModelState.IsValid)
            {

                //sort the employee and get the last insert employee.
                var lastemployee = db.Employees.OrderByDescending(c => c.EmployeeID).FirstOrDefault();
                if (lastemployee == null)
                {
                    employee.EmployeeID = 0;
                }
                else
                {
                    //using string substring method to get the number of the last inserted employee's EmployeeID 
                    employee.EmployeeID = lastemployee.EmployeeID + 1;
                }
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        /*public ActionResult Create([Bind(Include = "EmployeeID,EmployeeName,EmployeeAddress,EmployeePhone,EmployeeEmailID,EmployeeGender,EmployeeDesignation,SupervisorID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }*/

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,EmployeeName,EmployeeAddress,EmployeePhone,EmployeeEmailID,EmployeeGender,EmployeeDesignation,SupervisorID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
