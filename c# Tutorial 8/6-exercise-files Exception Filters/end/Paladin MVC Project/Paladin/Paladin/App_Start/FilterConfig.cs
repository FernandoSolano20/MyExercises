﻿using Paladin.Infrastructure;
using System.Web;
using System.Web.Mvc;

namespace Paladin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ExceptionLoggingFilter());
        }
    }
}