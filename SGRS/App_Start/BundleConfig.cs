using System.Web;
using System.Web.Optimization;

namespace SGRS
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jQuery-2.1.4.min.js",
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/metisMenu.min.js",
                "~/Scripts/jquery.slimscroll.js",
                "~/Scripts/waves.min.js",
                "~/plugins/jquery-sparkline/jquery.sparkline.min.js" ,
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/jquery.numeric.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

           


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/metismenu.min.css",
                "~/Content/icons.css",
                "~/Content/style.css", "~/Content/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/ExtencionesCSS").Include(           
            "~/Scripts/plugins/sweet-alert2/sweetalert2.css"
            ));


            bundles.Add(new ScriptBundle("~/bundles/ExtencionesJS").Include(
                "~/Scripts/plugins/sweet-alert2/sweetalert2.js"
            ));
        }
    }
}
