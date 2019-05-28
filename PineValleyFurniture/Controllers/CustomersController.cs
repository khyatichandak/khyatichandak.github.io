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
    public class CustomersController : Controller
    {
        private Entities db = new Entities();

        // GET: Customers
        /*public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }*/

        public ActionResult Index(string sortOrder, String searchString)
        {
            if ((searchString == null || searchString == ""))
            {
                ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewBag.SupervisorParm = sortOrder == "supervisor" ? "super_desc" : "super";
                var emp = from s in db.Customers
                          select s;
                switch (sortOrder)
                {
                    case "name_desc":
                        emp = db.Customers.OrderByDescending(s => s.CustomerName);
                        break;
                    case "super":
                        emp = db.Customers.OrderBy(s => s.CustomerCity);
                        break;
                    case "super_desc":
                        emp = db.Customers.OrderByDescending(s => s.CustomerCity);
                        break;
                    default:
                        emp = db.Customers.OrderBy(s => s.CustomerName);
                        break;
                }
                return View(emp.ToList());
            }
            else
            {
                return View(db.Customers.Where(x => x.CustomerName == searchString).ToList());
            }
        }


        // GET: Customers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "CustomerID,CustomerName,CustomerAddress,CustomerPostalCode,CustomerPhone,CustomerEmailID,CustomerCity")] Customer customer)
        {
            if (ModelState.IsValid)
            {

                //sort the employee and get the last insert employee.
                var lastCustomer = db.Customers.OrderByDescending(c => c.CustomerID).FirstOrDefault();
                if (lastCustomer == null)
                {
                    customer.CustomerID = 0;
                }
                else
                {
                    //using string substring method to get the number of the last inserted employee's EmployeeID 
                    customer.CustomerID = lastCustomer.CustomerID + 1;
                }
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        /*public ActionResult Create([Bind(Include = "CustomerID,CustomerName,CustomerAddress,CustomerPostalCode,CustomerPhone,CustomerEmailID,CustomerCity")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }*/

        // GET: Customers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CustomerName,CustomerAddress,CustomerPostalCode,CustomerPhone,CustomerEmailID,CustomerCity")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
