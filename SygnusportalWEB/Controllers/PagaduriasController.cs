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
    public class PagaduriasController : Controller
    {
        private sygnusportalEntities db = new sygnusportalEntities();

        // GET: Pagadurias
        public ActionResult Index()
        {
            var pagaduria = db.Pagaduria.Include(p => p.Ciudad).Include(p => p.Empresa).Include(p => p.TipoPagaduria);
            return View(pagaduria.ToList());
        }

        // GET: Pagadurias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagaduria pagaduria = db.Pagaduria.Find(id);
            if (pagaduria == null)
            {
                return HttpNotFound();
            }
            return View(pagaduria);
        }

        // GET: Pagadurias/Create
        public ActionResult Create()
        {
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre");
            ViewBag.emp_nit = new SelectList(db.Empresa, "emp_nit", "emp_nombre");
            ViewBag.tpa_id = new SelectList(db.TipoPagaduria, "tpa_id", "tpa_descripcion");
            return View();
        }

        // POST: Pagadurias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pag_id,pag_codigo,pag_nit,pag_dv,pag_nombre,pag_direccion,ciu_codigo,pag_telefonos,pag_url,pag_mail,pag_logo,pag_urlsygnus,pag_color,tpa_id,emp_nit,ent_id,pag_activa,pag_fax")] Pagaduria pagaduria)
        {
            if (ModelState.IsValid)
            {
                db.Pagaduria.Add(pagaduria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", pagaduria.ciu_codigo);
            ViewBag.emp_nit = new SelectList(db.Empresa, "emp_nit", "emp_nombre", pagaduria.emp_nit);
            ViewBag.tpa_id = new SelectList(db.TipoPagaduria, "tpa_id", "tpa_descripcion", pagaduria.tpa_id);
            return View(pagaduria);
        }

        // GET: Pagadurias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagaduria pagaduria = db.Pagaduria.Find(id);
            if (pagaduria == null)
            {
                return HttpNotFound();
            }
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", pagaduria.ciu_codigo);
            ViewBag.emp_nit = new SelectList(db.Empresa, "emp_nit", "emp_nombre", pagaduria.emp_nit);
            ViewBag.tpa_id = new SelectList(db.TipoPagaduria, "tpa_id", "tpa_descripcion", pagaduria.tpa_id);
            return View(pagaduria);
        }

        // POST: Pagadurias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pag_id,pag_codigo,pag_nit,pag_dv,pag_nombre,pag_direccion,ciu_codigo,pag_telefonos,pag_url,pag_mail,pag_logo,pag_urlsygnus,pag_color,tpa_id,emp_nit,ent_id,pag_activa,pag_fax")] Pagaduria pagaduria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagaduria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", pagaduria.ciu_codigo);
            ViewBag.emp_nit = new SelectList(db.Empresa, "emp_nit", "emp_nombre", pagaduria.emp_nit);
            ViewBag.tpa_id = new SelectList(db.TipoPagaduria, "tpa_id", "tpa_descripcion", pagaduria.tpa_id);
            return View(pagaduria);
        }

        // GET: Pagadurias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagaduria pagaduria = db.Pagaduria.Find(id);
            if (pagaduria == null)
            {
                return HttpNotFound();
            }
            return View(pagaduria);
        }

        // POST: Pagadurias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagaduria pagaduria = db.Pagaduria.Find(id);
            db.Pagaduria.Remove(pagaduria);
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
