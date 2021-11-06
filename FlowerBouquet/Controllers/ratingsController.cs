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
    public class ratingsController : Controller
    {
        private FlowerBouquetContext db = new FlowerBouquetContext();

        // GET: ratings
        public ActionResult Index()
        {
            var ratings = db.ratings.Include(r => r.products);
            return View(ratings.ToList());
        }

        // GET: ratings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rating rating = db.ratings.Find(id);
            if (rating == null)
            {
                return HttpNotFound();
            }
            return View(rating);
        }

        // GET: ratings/Create
        public ActionResult Create()
        {
            ViewBag.productId = new SelectList(db.products, "productId", "productName");
            return View();
        }

        // POST: ratings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ratingID,productId,ratings")] rating rating)
        {
            if (ModelState.IsValid)
            {
                db.ratings.Add(rating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.productId = new SelectList(db.products, "productId", "productName", rating.productId);
            return View(rating);
        }

        // GET: ratings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rating rating = db.ratings.Find(id);
            if (rating == null)
            {
                return HttpNotFound();
            }
            ViewBag.productId = new SelectList(db.products, "productId", "productName", rating.productId);
            return View(rating);
        }

        // POST: ratings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ratingID,productId,ratings")] rating rating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.productId = new SelectList(db.products, "productId", "productName", rating.productId);
            return View(rating);
        }

        // GET: ratings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rating rating = db.ratings.Find(id);
            if (rating == null)
            {
                return HttpNotFound();
            }
            return View(rating);
        }

        // POST: ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            rating rating = db.ratings.Find(id);
            db.ratings.Remove(rating);
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
