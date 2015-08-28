using System.Web;
using System.Web.Optimization;

namespace SGAL.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-mask").Include(
                     "~/Scripts/jquery-mask.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/locales/bootstrap-datepicker.pt-BR.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-datepicker").Include(
                      "~/Content/bootstrap-datepicker3.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-table").Include(
                    "~/Scripts/bootstrap-table.js",
                    "~/Scripts/locale/bootstrap-table-pt-BR.js",
                    "~/Scripts/extensions/export/tableExport.js",
                    "~/Scripts/extensions/export/bootstrap-table-export.js",
                    "~/Scripts/extensions/export/libs/FileSaver/FileSaver.min.js",
                    "~/Scripts/extensions/export/libs/html2canvas/html2canvas.min.js",
                    "~/Scripts/extensions/export/libs/jsPDF/jspdf.min.js",
                    "~/Scripts/extensions/export/libs/jsPDF-AutoTable/jspdf.plugin.autotable.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/bootstrap-table").Include(
           "~/Content/bootstrap-table.css"));

            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                "~/Scripts/select2.js",
                "~/Scripts/i18n/pt-BR.js"));

            bundles.Add(new StyleBundle("~/Content/select2").Include(
            "~/Content/css/select2.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/noty").Include(
                              "~/Scripts/noty/jquery.noty.js",
                              "~/Scripts/noty/layouts/bottom.js",
                              "~/Scripts/noty/layouts/bottomCenter.js",
                              "~/Scripts/noty/layouts/bottomLeft.js",
                              "~/Scripts/noty/layouts/bottomRight.js",
                              "~/Scripts/noty/layouts/center.js",
                              "~/Scripts/noty/layouts/centerLeft.js",
                              "~/Scripts/noty/layouts/centerRight.js",
                              "~/Scripts/noty/layouts/inline.js",
                              "~/Scripts/noty/layouts/top.js",
                              "~/Scripts/noty/layouts/topCenter.js",
                              "~/Scripts/noty/layouts/topLeft.js",
                              "~/Scripts/noty/layouts/topRight.js",
                              "~/Scripts/noty/themes/default.js",
                              "~/Scripts/noty/themes/relax.js"));

            bundles.Add(new ScriptBundle("~/bundles/util").Include(
                    "~/Scripts/Funcoes.js"));

            bundles.Add(new StyleBundle("~/Content/animate").Include(
            "~/Content/animate.css"));
        }
    }
}
