using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MvcNormal
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AddDisplayModes();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void AddDisplayModes()
        {
            DisplayModeProvider.Instance.Modes.Insert(0,
               new DefaultDisplayMode("Mobile")
               {
                   ContextCondition = ctx => ctx.GetOverriddenUserAgent().Contains("iPad")
               });

            DisplayModeProvider.Instance.Modes.Insert(0,
               new DefaultDisplayMode("Silk")
               {
                   ContextCondition = ctx => ctx.GetOverriddenUserAgent().Contains("Silk")
               });
        }
    }
}