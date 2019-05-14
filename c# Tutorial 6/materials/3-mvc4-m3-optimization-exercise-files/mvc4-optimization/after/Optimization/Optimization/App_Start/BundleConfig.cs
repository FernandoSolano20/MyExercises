using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Optimization
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                        .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js")
                        .Include("~/Scripts/jquery*")
                        .Include("~/Scripts/mustache.js")
                        .Include("~/Scripts/bootstrap.js"));

            var animalsBundle = new ScriptBundle("~/bundles/animals")
                .Include("~/Scripts/animals.coffee");
            animalsBundle.Transforms.Insert(0, new CoffeeBundler.CoffeeBundler());
            bundles.Add(animalsBundle);

            BundleTable.EnableOptimizations = true;
        }
    }
}