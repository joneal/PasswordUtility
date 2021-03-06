﻿using System.Web.Optimization;

namespace PasswordUtility.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/main.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap-slider.js",
                        "~/Scripts/ZeroClipboard.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/font-awesome.min.css",
                      "~/Content/bootstrap-slider.css"));
        }
    }
}
