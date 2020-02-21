using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SygnusportalBD;

namespace SygnusportalWEB.Controllers
{
    public class TipoPagaduriasController : Controller
    {
        private sygnusportalEntities db = new sygnusportalEntities();

        // GET: TipoPagadurias
        public ActionResult Index()
        {
            return View(db.TipoPagaduria.ToList());
        }

        // GET: TipoPagadurias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagaduria tipoPagaduria = db.TipoPagaduria.Find(id);
            if (tipoPagaduria == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagaduria);
        }

        // GET: TipoPagadurias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPagadurias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tpa_id,tpa_descripcion")] TipoPagaduria tipoPagaduria)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.TipoPagaduria.Add(tipoPagaduria);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception Ex)
                {
                    ViewBag.Err = "Error al tratar de guardar el Registro " + Ex.Message;
                }
            }

            return View(tipoPagaduria);
        }

        // GET: TipoPagadurias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagaduria tipoPagaduria = db.TipoPagaduria.Find(id);
            if (tipoPagaduria == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagaduria);
        }

        // POST: TipoPagadurias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tpa_id,tpa_descripcion")] TipoPagaduria tipoPagaduria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoPagaduria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoPagaduria);
        }

        // GET: TipoPagadurias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagaduria tipoPagaduria = db.TipoPagaduria.Find(id);
            if (tipoPagaduria == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagaduria);
        }

        // POST: TipoPagadurias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoPagaduria tipoPagaduria = db.TipoPagaduria.Find(id);
            db.TipoPagaduria.Remove(tipoPagaduria);
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
