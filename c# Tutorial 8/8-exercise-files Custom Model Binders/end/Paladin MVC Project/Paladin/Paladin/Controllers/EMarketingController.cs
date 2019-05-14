using Paladin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Paladin.Controllers
{
    public class EMarketingController : Controller
    {
        private PaladinDbContext _context;
        
        public EMarketingController(PaladinDbContext context)
        {
            _context = context;
        }

        public ActionResult WeeklyReport(EWeeklyReport weeklyReport)
        {
            if (ModelState.IsValid)
            {
                _context.WeeklyReports.Add(weeklyReport);
                _context.SaveChanges();
                return Content("OK");
            }

            return Content("Error");
        }

        public ActionResult MonthlyReport(EMonthlyReport monthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.MonthlyReports.Add(monthlyReport);
                _context.SaveChanges();
                return Content("OK");
            }

            return Content("Error");
        }
    }
}