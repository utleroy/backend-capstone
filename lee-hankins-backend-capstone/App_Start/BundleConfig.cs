using System.Web;
using System.Web.Optimization;

namespace lee_hankins_backend_capstone
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                   .IncludeDirectory("~/app/content/css/", "*.css", true)
                   );

            bundles.Add(new StyleBundle("~/bundles/materialize/css")
                   .IncludeDirectory("~/Content/materialize/css/", "*.css", true)
                   );

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-resource.js")
                .IncludeDirectory("~/app/js/", "*.js", true)
                .IncludeDirectory("~/app/controllers/", "*.js", true)
                );
            bundles.Add(new ScriptBundle("~/bundles/materialize")
                   .IncludeDirectory("~/Scripts/materialize/", "*.css", true)
                   );


        }
    }
}
