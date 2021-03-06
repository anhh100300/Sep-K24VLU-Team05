using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEP21.Models;

namespace SEP21.Controllers
{
    public class TuyenDungController : Controller
    {
        private SEP24Team5Entities db = new SEP24Team5Entities();

        // GET: TuyenDung
        public ActionResult Index()
        {
            return View(db.TuyenDungs.ToList());
        }

        // GET: TuyenDung/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuyenDung tuyenDung = db.TuyenDungs.Find(id);
            if (tuyenDung == null)
            {
                return HttpNotFound();
            }
            return View(tuyenDung);
        }

        // GET: TuyenDung/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TuyenDung/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TuyenDung tuyenDung)
        {
            if (ModelState.IsValid)
            {
                db.TuyenDungs.Add(tuyenDung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuyenDung);
        }

        // GET: TuyenDung/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuyenDung tuyenDung = db.TuyenDungs.Find(id);
            if (tuyenDung == null)
            {
                return HttpNotFound();
            }
            return View(tuyenDung);
        }

        // POST: TuyenDung/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TuyenDung tuyenDung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuyenDung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuyenDung);
        }

        // GET: TuyenDung/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuyenDung tuyenDung = db.TuyenDungs.Find(id);
            if (tuyenDung == null)
            {
                return HttpNotFound();
            }
            return View(tuyenDung);
        }

        // POST: TuyenDung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TuyenDung tuyenDung = db.TuyenDungs.Find(id);
            db.TuyenDungs.Remove(tuyenDung);
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
