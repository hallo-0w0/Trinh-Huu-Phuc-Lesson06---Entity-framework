using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThpLession06CF.Models;

namespace ThpLession06CF.Controllers
{
    public class ThpBooksController : Controller
    {
        private ThpBookStore db = new ThpBookStore();

        // GET: ThpBooks
        public ActionResult Index()
        {
            return View(db.ThpBooks.ToList());
        }

        // GET: ThpBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpBook thpBook = db.ThpBooks.Find(id);
            if (thpBook == null)
            {
                return HttpNotFound();
            }
            return View(thpBook);
        }

        // GET: ThpBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThpBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThpId,ThpBookId,ThpTitle,ThpAuthor,ThpYear,ThpPulisher,ThpPicture,ThpCategoryId")] ThpBook thpBook)
        {
            if (ModelState.IsValid)
            {
                db.ThpBooks.Add(thpBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thpBook);
        }

        // GET: ThpBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpBook thpBook = db.ThpBooks.Find(id);
            if (thpBook == null)
            {
                return HttpNotFound();
            }
            return View(thpBook);
        }

        // POST: ThpBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThpId,ThpBookId,ThpTitle,ThpAuthor,ThpYear,ThpPulisher,ThpPicture,ThpCategoryId")] ThpBook thpBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thpBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thpBook);
        }

        // GET: ThpBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpBook thpBook = db.ThpBooks.Find(id);
            if (thpBook == null)
            {
                return HttpNotFound();
            }
            return View(thpBook);
        }

        // POST: ThpBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThpBook thpBook = db.ThpBooks.Find(id);
            db.ThpBooks.Remove(thpBook);
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
