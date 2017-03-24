using System.Web;
using System.Web.Optimization;

namespace BethCastilloPortfolio
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryscrolly").Include(
                        "~/Content/assets/js/jquery.scrolly.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/skel").Include(
                       "~/Content/assets/js/skel.min.js",
                       "~/Content/assets/js/skel-viewport.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
               "~/Content/assets/js/util.js",
               "~/Content/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/css/main.css"));
        }
    }
}