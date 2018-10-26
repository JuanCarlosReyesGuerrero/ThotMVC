using System.Web;
using System.Web.Optimization;

namespace ThotMVC
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            //// para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));





            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/vendor/bootstrap/css/bootstrap.css",
                      "~/Content/assets/vendor/font-awesome/css/font-awesome.css",
                      "~/Content/assets/vendor/magnific-popup/magnific-popup.css",
                      "~/Content/assets/vendor/bootstrap-datepicker/css/datepicker3.css",
                      "~/Content/assets/vendor/bootstrap-fileupload/bootstrap-fileupload.min.css",
                      "~/Content/assets/stylesheets/theme.css",
                      "~/Content/assets/stylesheets/skins/default.css",
                      "~/Content/assets/stylesheets/theme-custom.css"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/assets/vendor/modernizr/modernizr.js",
                        "~/Content/assets/vendor/jquery/jquery.js",
                        "~/Content/assets/vendor/jquery-browser-mobile/jquery.browser.mobile.js",
                        "~/Content/assets/vendor/bootstrap/js/bootstrap.js",
                        "~/Content/assets/vendor/nanoscroller/nanoscroller.js",
                        "~/Content/assets/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js",
                        "~/Content/assets/vendor/magnific-popup/magnific-popup.js",
                        "~/Content/assets/vendor/jquery-placeholder/jquery.placeholder.js",
                        "~/Content/assets/vendor/jquery-autosize/jquery.autosize.js",
                        "~/Content/assets/vendor/bootstrap-fileupload/bootstrap-fileupload.min.js",
                        "~/Content/assets/javascripts/theme.js",
                        "~/Content/assets/javascripts/theme.custom.js",
                        "~/Content/assets/javascripts/theme.init.js"));


        }
    }
}
