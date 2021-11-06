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
    public class UserproductsController : Controller
    {
        private FlowerBouquetContext db = new FlowerBouquetContext();

        // GET: Userproducts
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.Categories);
            return View(products.ToList());
        }

        // GET: Userproducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Userproducts/Create
        public ActionResult Create()
        {
            ViewBag.categoryId = new SelectList(db.Categories, "categoryId", "categoryName");
            return View();
        }

        // POST: Userproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "productId,productName,categoryId,isActive,isdelete,createdDate,modifiedDate,description,isFeatured,image,quanity,price")] product product)
        {
             
            if (ModelState.IsValid)
            {
               
                 
                db.products.Add(product);
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryId = new SelectList(db.Categories, "categoryId", "categoryName", product.categoryId);
            return View(product);
        }

      
        public ActionResult sample(int? id)
        {
            //ViewBag.price=id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            Cart cart = new Cart();
            int pid = product.productId * 2;
            cart.cartID = product.productId + pid;
            cart.productId = product.productId;
            cart.quantity = product.quanity;
            cart.price = product.price;
            cart.createdDate = DateTime.Now;
            db.Carts.Add(cart);
            db.SaveChanges();
            var carts = db.Carts.Include(p => p.products);
            return View(carts.ToList());


            //return View();
        }



        // GET: Userproducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryId = new SelectList(db.Categories, "categoryId", "categoryName", product.categoryId);
            return View(product);
        }

        // POST: Userproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productId,productName,categoryId,isActive,isdelete,createdDate,modifiedDate,description,isFeatured,image,quanity,price")] product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryId = new SelectList(db.Categories, "categoryId", "categoryName", product.categoryId);
            return View(product);
        }

        // GET: Userproducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Userproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.products.Find(id);
            db.products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult removeitem(int id)
        {
            Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
            //return View();
            return RedirectToAction("sampleIndex");


        }
        public ActionResult sampleIndex()
        {
            var cartlist = db.Carts.Include(p => p.products);
            return View(cartlist.ToList());
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
