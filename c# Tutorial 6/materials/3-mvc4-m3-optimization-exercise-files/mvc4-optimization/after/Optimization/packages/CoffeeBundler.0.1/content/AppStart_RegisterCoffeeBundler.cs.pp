using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Microsoft.Web.Infrastructure;
 
[assembly: WebActivator.PostApplicationStartMethod(typeof($rootnamespace$.AppStart_RegisterCoffeeBundler), "Start")]
 
namespace $rootnamespace$ {

    public static class AppStart_RegisterCoffeeBundler {
        public static void Start() {
            var coffeeBundle = new DynamicFolderBundle("coffee", new CoffeeBundler.CoffeeBundler(), "*.coffee");
            BundleTable.Bundles.Add(coffeeBundle);
        }
    }
}