using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6MVC5010.Models;

namespace EF6MVC5010.Controllers
{
    public class PostCodesController : Controller
    {
        private UKPostCodesEntities db = new UKPostCodesEntities();

        // GET: PostCodes
        public ActionResult Index()
        {
            return View(db.PostCodes.ToList());
        }

        // GET: PostCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostCode postCode = db.PostCodes.Find(id);
            if (postCode == null)
            {
                return HttpNotFound();
            }
            return View(postCode);
        }

        // GET: PostCodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pID,postcode,latitude,longitude")] PostCode postCode)
        {
            if (ModelState.IsValid)
            {
                db.PostCodes.Add(postCode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postCode);
        }

        // GET: PostCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostCode postCode = db.PostCodes.Find(id);
            if (postCode == null)
            {
                return HttpNotFound();
            }
            return View(postCode);
        }

        // POST: PostCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pID,postcode,latitude,longitude")] PostCode postCode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postCode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postCode);
        }

        // GET: PostCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostCode postCode = db.PostCodes.Find(id);
            if (postCode == null)
            {
                return HttpNotFound();
            }
            return View(postCode);
        }

        // POST: PostCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostCode postCode = db.PostCodes.Find(id);
            db.PostCodes.Remove(postCode);
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
