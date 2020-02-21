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
    public class EmpresasController : Controller
    {
        private sygnusportalEntities db = new sygnusportalEntities();

        // GET: Empresas
        public ActionResult Index()
        {
            var empresa = db.Empresa.Include(e => e.Ciudad);
            return View(empresa.ToList());
        }

        // GET: Empresas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresa.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre");
            return View();
        }

        // POST: Empresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "emp_nit,emp_dv,emp_nombre,emp_direccion,ciu_codigo,emp_telefono,emp_logo,emp_url")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Empresa.Add(empresa);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception Ex)
                {
                    ViewBag.Err = "Error al tratar de guardar el Registro " + Ex.Message;
                }
            }

            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", empresa.ciu_codigo);
            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresa.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", empresa.ciu_codigo);
            return View(empresa);
        }

        // POST: Empresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "emp_nit,emp_dv,emp_nombre,emp_direccion,ciu_codigo,emp_telefono,emp_logo,emp_url")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ciu_codigo = new SelectList(db.Ciudad, "ciu_codigo", "ciu_nombre", empresa.ciu_codigo);
            return View(empresa);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresa.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Empresa empresa = db.Empresa.Find(id);
            db.Empresa.Remove(empresa);
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
