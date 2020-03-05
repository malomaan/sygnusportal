using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SygnusportalBD;

namespace SygnusportalWEB.Controllers
{
    public class HomeController : Controller
    {
        private sygnusportalEntities db = new sygnusportalEntities();

        public ActionResult Index()
        {
            var TPagaduria = db.Pagaduria_ListActivasPeriodos().ToList();
            return View(TPagaduria);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}