using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exercice1_APP_MVC.Models;

namespace Exercice1_APP_MVC.Controllers
{
    public class OuvragesController : Controller
    {
        private ModelOuvrageContainer db = new ModelOuvrageContainer();

        // GET: Ouvrages
        public ActionResult Index()
        {
            return View(db.OuvrageSet.ToList());
        }

        // GET: Ouvrages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.OuvrageSet.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // GET: Ouvrages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ouvrages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Num_Ouv,Titre_Ouv,PU,Nb_Exp")] Ouvrage ouvrage)
        {
            if (ModelState.IsValid)
            {
                db.OuvrageSet.Add(ouvrage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ouvrage);
        }

        // GET: Ouvrages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.OuvrageSet.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // POST: Ouvrages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Num_Ouv,Titre_Ouv,PU,Nb_Exp")] Ouvrage ouvrage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ouvrage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ouvrage);
        }

        // GET: Ouvrages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.OuvrageSet.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // POST: Ouvrages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ouvrage ouvrage = db.OuvrageSet.Find(id);
            db.OuvrageSet.Remove(ouvrage);
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
