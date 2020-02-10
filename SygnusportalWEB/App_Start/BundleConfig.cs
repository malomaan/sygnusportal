﻿using System.Web;
using System.Web.Optimization;

namespace SygnusportalWEB
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/all.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css"));


            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                   "~/Scripts/DataTables/jquery.dataTables.js", "~/Scripts/DataTables/dataTables.tableTools.js",
                  "~/Scripts/DataTables/dataTables.scroller.min.js",
                   "~/Scripts/DataTables/dataTables.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
          "~/Scripts/bootstrap.js",
          "~/Scripts/bootstrap-datetimepicker.min.js",
          "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                    "~/Scripts/jquery-ui-1.12.1.js"));

            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
                    "~/Content/jquery-ui.css"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            "~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
            "~/Content/jquery-ui.css"));
        }
    }
}
