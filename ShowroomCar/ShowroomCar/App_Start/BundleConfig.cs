using System.Web;
using System.Web.Optimization;

namespace ShowroomCar
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Add user Csss
            bundles.Add(new StyleBundle("~/ShowroomCar/css").Include(
                "~/Content/user/lib/owlcarousel/assets/owl.carousel.min.css",
                "~/Content/user/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css",
                "~/Content/user/css/bootstrap.min.css",
                "~/Content/user/css/style.css"
                ));

            //Add javascript user
            bundles.Add(new ScriptBundle("~/ShowroomCar/js").Include(
                "~/Content/user/lib/easing/easing.min.js",
                "~/Content/user/lib/waypoints/waypoints.min.js",
                "~/Content/user/lib/owlcarousel/owl.carousel.min.js",
                "~/Content/user/lib/tempusdominus/js/moment.min.js",
                "~/Content/user/lib/tempusdominus/js/moment-timezone.min.js",
                "~/Content/user/lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js",
                "~/Content/user/js/main.js"
                ));

            //Add admin Csss
            bundles.Add(new StyleBundle("~/AdminCar/css").Include(
                "~/Content/admin/assets/main.css"
                ));

            //Add javascript admin
            bundles.Add(new ScriptBundle("~/AdminCar/js").Include(
                "~/Content/admin/assets/scripts/main.js"
                ));

        }
    }
}
