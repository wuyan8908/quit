using System.Web;
using System.Web.Optimization;

namespace quit
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/calculator").Include(
                        "~/Scripts/Calculator/button.min.js",
                        "~/Scripts/Calculator/core.min.js",
                        "~/Scripts/Calculator/datepicker.min.js",
                        "~/Scripts/Calculator/jquery-migrate.min.js",
                        "~/Scripts/Calculator/jquery.js",
                        "~/Scripts/Calculator/jQuery.stringify.js",
                        "~/Scripts/Calculator/jquery.validate.js",
                        "~/Scripts/Calculator/mouse.min.js",
                        "~/Scripts/Calculator/position.min.js",
                        "~/Scripts/Calculator/slider.min.js",
                        "~/Scripts/Calculator/tooltip.min.js",
                        "~/Scripts/Calculator/widget.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css/calculator").Include(
                      "~/css/calcultor/jquery-ui-1.8.20.custom.css",
                      "~/css/calcultor/style.css",
                      "~/css/calcultor/stylepublic.css"
                      ));
        }
    }
}
