using System.Web;
using System.Web.Optimization;

namespace EpioneMVC
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

            bundles.Add(new StyleBundle("~/bundle/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/main.css",
                      "~/Content/authentication.css",
                      "~/Content/color_skins.css"
                      ));
            bundles.Add(new StyleBundle("~/bundle/homecss").Include(
                     "~/Content/bootstrap.min.css",
                     "~/Content/jquery-jvectormap-2.0.3.min.css",
                     "~/Content/morris.min.css",
                     "~/Content/color_skins.css",
                     "~/Content/main.css"
                     ));

            bundles.Add(new ScriptBundle("~/bundle/js").Include(
                      "~/Scripts/vendorscripts.bundle.js",
                      "~/Scripts/libscripts.bundle.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundle/homejs").Include(
                                 "~/Scripts/vendorscripts.bundle.js",
                                 "~/Scripts/libscripts.bundle.js",
                                 "~/Scripts/morrisscripts.bundle.js",
                                 "~/Scripts/jvectormap.bundle.js",
                                 "~/Scripts/knob.bundle.js",
                                 "~/Scripts/mainscripts.bundle.js",
                                 "~/Scripts/index.js"
                                 ));

        }
    }
}
