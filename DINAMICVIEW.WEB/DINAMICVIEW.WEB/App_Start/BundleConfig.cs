using System.Web;
using System.Web.Optimization;

namespace DINAMICVIEW.WEB
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

            bundles.Add(new StyleBundle("~/css/css").Include(
                                        "~/css/main.css",
                                        "~/css/util.css",
                                        "~/css/font-awesome.min.css",
                                        "~/css/icon-font.min.css",
                                        "~/css/animate.css",
                                        "~/css/animsition.css",
                                        "~/css/bootstrap.min.css",
                                        "~/css/hamburgers.css",
                                        "~/css/daterangepicker.css",
                                        "~/css/perfect-scrollbar.css",
                                        "~/css/angular-block-ui.css",
                                        "~/css/ui-grid.css",
                                        "~/css/select2.css"));

            bundles.Add(new ScriptBundle("~/js/js").Include(
                                         "~/js/jquery-1.10.2.js",
                                         "~/js/angular.js",
                                         "~/js/angular-block-ui.js",
                                         "~/js/ui-grid.js",
                                         "~/js/select2.js",
                                         "~/js/daterangepicker.js",
                                         "~/js/moment.js",
                                         "~/js/bootstrap.js",
                                         "~/js/popper.js",
                                         "~/js/tooltip.js",
                                         "~/js/countdowntime.js",
                                         "~/js/Login_v5.js"));

        }
    }
}
