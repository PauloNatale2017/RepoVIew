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

            bundles.Add(new StyleBundle("~/css").Include(
                     "~/Views/SharedLayers/Context/main.css",
                     "~/Views/SharedLayers/Context/util.css",
                     "~/Views/SharedLayers/Context/font-awesome.min.css",
                     "~/Views/SharedLayers/Context/icon-font.min.css",
                     "~/Views/SharedLayers/Context/animate.css",
                     "~/Views/SharedLayers/Context/animsition.css",
                     "~/Views/SharedLayers/Context/bootstrap.min.css",
                     "~/Views/SharedLayers/Context/hamburgers.css",
                     "~/Views/SharedLayers/Context/daterangepicker.css",
                     "~/Views/SharedLayers/Context/perfect-scrollbar.css",
                     "~/Views/SharedLayers/Context/select2.css"));

            bundles.Add(new ScriptBundle("~/js").Include(
                      "~/Views/SharedLayers/Context/main.js",
                      "~/Views/SharedLayers/Context/select2.js",
                      "~/Views/SharedLayers/Context/daterangepicker.js",
                      "~/Views/SharedLayers/Context/moment.js",
                      "~/Views/SharedLayers/Context/bootstrap.js",
                      "~/Views/SharedLayers/Context/popper.js",
                      "~/Views/SharedLayers/Context/tooltip.js",
                      "~/Views/SharedLayers/Context/countdowntime.js"));

        }
    }
}
