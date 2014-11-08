using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECommerce.Data.Models;

namespace ECommerce.GUI.Controllers
{
    public class ProductController : Controller
    {
        private ECommerceContext db = new ECommerceContext();

        // GET: /Product/
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.category).Include(p => p.promotion).Include(p => p.user);
            return View(products.ToList());
        }

        // GET: /Product/Details/5
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

        // GET: /Product/Create
        public ActionResult Create()
        {
            ViewBag.category_idCategory = new SelectList(db.categories, "idCategory", "name");
            ViewBag.promotion_idPromotion = new SelectList(db.promotions, "idPromotion", "description");
            ViewBag.supplier_idUser = new SelectList(db.users, "idUser", "DTYPE");
            return View();
        }

        // POST: /Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="idProduct,currency,date,description,name,price,quantity,taxe,category_idCategory,promotion_idPromotion,supplier_idUser")] product product)
        {
            if (ModelState.IsValid)
            {
                db.products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.category_idCategory = new SelectList(db.categories, "idCategory", "name", product.category_idCategory);
            ViewBag.promotion_idPromotion = new SelectList(db.promotions, "idPromotion", "description", product.promotion_idPromotion);
            ViewBag.supplier_idUser = new SelectList(db.users, "idUser", "DTYPE", product.supplier_idUser);
            return View(product);
        }

        // GET: /Product/Edit/5
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
            ViewBag.category_idCategory = new SelectList(db.categories, "idCategory", "name", product.category_idCategory);
            ViewBag.promotion_idPromotion = new SelectList(db.promotions, "idPromotion", "description", product.promotion_idPromotion);
            ViewBag.supplier_idUser = new SelectList(db.users, "idUser", "DTYPE", product.supplier_idUser);
            return View(product);
        }

        // POST: /Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="idProduct,currency,date,description,name,price,quantity,taxe,category_idCategory,promotion_idPromotion,supplier_idUser")] product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_idCategory = new SelectList(db.categories, "idCategory", "name", product.category_idCategory);
            ViewBag.promotion_idPromotion = new SelectList(db.promotions, "idPromotion", "description", product.promotion_idPromotion);
            ViewBag.supplier_idUser = new SelectList(db.users, "idUser", "DTYPE", product.supplier_idUser);
            return View(product);
        }

        // GET: /Product/Delete/5
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

        // POST: /Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.products.Find(id);
            db.products.Remove(product);
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
