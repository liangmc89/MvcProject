using System.Web;
using System.Web.Optimization;

namespace MvcProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/nicescroll").Include(
                      "~/Scripts/jquery.nicescroll.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css"));
            bundles.Add(new StyleBundle("~/Content/AdminStyle").Include(
                     "~/Content/css/bootstrap.css",
                     "~/Content/css/Admin.css",
                     "~/Content/css/font-awesome.css",
                     "~/Content/css/graph.css",
                     "~/Content/css/icon-font.min.css",
                     "~/Content/css/animate.css"
                   ));

        }
    }
}
