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
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      //"~/app/content/js/bootstrap.js",
                      //"~/app/content/js/bootstrap.min.js",
                      //"~/app/content/js/jquery.ui.min.js",
                      //"~/app/content/js/jquery.min.js",
                      //"~/app/content/js/jquery.tocify.min.js",
                      //"~/app/content/js/prettify.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/app/content/css/css").Include(
                      "~/app/content/css/bootstrap.css",
                      "~/app/content/css/bootstrap.min.css",
                      "~/app/content/css/documentation.css",
                      "~/app/content/css/font-awesome.min.css",
                      "~/app/content/css/jquery.tocify.css",
                      "~/app/content/css/prettify.css",
                      "~/app/content/css/style-library-1.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-resource.js",
                "~/app/js/app.js")
                .IncludeDirectory("~/app/js/", "*.js", true)
                .IncludeDirectory("~/app/controllers/", "*.js", true)
                
                //.IncludeDirectory("~/app/content/css/", "*.css", true)
                //.IncludeDirectory("~/app/content/js/", "*.js", true)
                //.IncludeDirectory("~/app/content/fonts/", "*.eot, svg, ttf, woff, otf, ", true)
                //.IncludeDirectory("~/app/content/ico/", "*.png", true)
                //.IncludeDirectory("~/app/content/images/", "*.png", true)
                );

        }
    }
}
