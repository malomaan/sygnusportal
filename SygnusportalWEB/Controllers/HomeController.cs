using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SygnusportalBD;
using System.Data;
using System.Data.Entity;
using SygnusportalPRC;

namespace SygnusportalWEB.Controllers
{
    public class HomeController : Controller
    {
        private sygnusportalEntities db = new sygnusportalEntities();
        private PagaduriaPRC BD = new PagaduriaPRC();

        public ActionResult Index(string Id)
        {
            //var TPagaduria = db.Pagaduria_ListActivasPeriodos().ToList();
            if (Id is null)
            {
                Id = "";
            }
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;
            var TPagaduriaNombre = BD.Pagaduria_ListActivasPeriodos_Nombre(Id).ToList();
            return View(TPagaduriaNombre);
        }

        public ActionResult Habilitadas()
        {
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;
            var TPagaduria = db.Pagaduria_ListActivasPeriodos_Habilitada().ToList();
            return View(TPagaduria);
        }



        public ActionResult Nombres(string Id)
        {
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;
            var TPagaduria = db.Pagaduria_ListActivasPeriodos_Nombre(Id).ToList();
            return View(TPagaduria);
        }



        public ActionResult Tipos(int Id)
        {
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;
            var TPagaduria = db.Pagaduria_ListActivasPeriodos_Tipo(Id).ToList();
            return View(TPagaduria);
        }



        public ActionResult About()
        {
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            List<TipoPagaduria> TipoList = db.TipoPagaduria.ToList();
            ViewBag.Tipo = TipoList;

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}