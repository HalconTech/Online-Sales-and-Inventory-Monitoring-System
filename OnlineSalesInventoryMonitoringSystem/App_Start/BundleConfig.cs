using System.Web;
using System.Web.Optimization;

namespace OnlineSalesInventoryMonitoringSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-ui.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            //Other JS PlugIns
            bundles.Add(new ScriptBundle("~/bundles/others").Include(
                       "~/Scripts/raphael.min.js",
                       "~/Scripts/morris.min.js",
                       "~/Scripts/jquery.sparkline.min.js",
                       "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                       "~/Scripts/jquery-jvectormap-world-mill-en.js",
                       "~/Scripts/jquery.knob.min.js",
                       "~/Scripts/moment.min.js",
                       "~/Scripts/daterangepicker.js",
                       "~/Scripts/bootstrap-datepicker.min.js",
                       "~/Scripts/bootstrap3-wysihtml5.all.min.js",
                       "~/Scripts/jquery.slimscroll.min.js",
                       "~/Scripts/fastclick.js",
                       "~/Scripts/adminlte.min.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/ionicons.min.css",
                      "~/Content/AdminLTE.min.css",
                      "~/Content/morris.css",
                      "~/Content/jquery-jvectormap.css",
                      "~/Content/bootstrap-datepicker.min.css",
                      "~/Content/daterangepicker.css",
                      "~/Content/bootstrap3-wysihtml5.min.css"
                      ));
        }
    }
}
