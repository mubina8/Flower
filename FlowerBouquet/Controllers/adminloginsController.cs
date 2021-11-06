using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlowerBouquet.Data;
using FlowerBouquet.Models;

namespace FlowerBouquet.Controllers
{
    public class adminloginsController : Controller
    {
        private FlowerBouquetContext db = new FlowerBouquetContext();

        // GET: adminlogins
        public ActionResult Index()
        {
            return View(db.adminlogins.ToList());
        }

        // GET: adminlogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adminlogin adminlogin = db.adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // GET: adminlogins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: adminlogins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "adminID,username,password")] adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.adminlogins.Add(adminlogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminlogin);
        }
        public ActionResult Login([Bind(Include = "adminID,username,password")] adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.adminlogins.Add(adminlogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminlogin);
        }
        public ActionResult LoginNew([Bind(Include = "adminID,username,password")] adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.adminlogins.Add(adminlogin);
                db.SaveChanges();
                return RedirectToAction("dashboard");
            }

            return View(adminlogin);
        }
        public ActionResult dashboard()
        {
            return View();
        }


        // GET: adminlogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adminlogin adminlogin = db.adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // POST: adminlogins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "adminID,username,password")] adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminlogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminlogin);
        }

        // GET: adminlogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adminlogin adminlogin = db.adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // POST: adminlogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            adminlogin adminlogin = db.adminlogins.Find(id);
            db.adminlogins.Remove(adminlogin);
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
