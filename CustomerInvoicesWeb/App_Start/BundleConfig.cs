using System.Web;
using System.Web.Optimization;

namespace CustomerInvoicesWeb
{
    /// <summary>
    /// Clase de bundles, encargada de generar los min de los archivos css y js
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Método que registra todos los bundles
        /// </summary>
        /// <param name="bundles"></param>
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

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/jquery-ui.structure.css",
                      "~/Content/jquery-ui.theme.css"));
        }
    }
}
