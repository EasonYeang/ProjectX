using System.Web.Optimization;

namespace ProjectX
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //don't use .min package here, otherwise it will not work.

            //bundle js files
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Scripts/jquery-3.1.1.js",
                "~/layui/layui.js",
                "~/layui/layui.all.js"
                ));

            //bundle css files
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Plugins/font-awesome/css/font-awesome.css",                
                "~/Plugins/layui/css/layui.css",
                "~/Plugins/layui/css/modules/laydate/default/laydate.css",
                "~/Plugins/layui/css/modules/layer/default/layer.css",
                "~/Plugins/layui/css/modules/code.css",
                "~/CSS/PX.css"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}