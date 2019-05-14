using Paladin.Infrastructure;
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

        public ActionResult WeeklyReport()
        {
            var serializer = new XmlSerializer(typeof(EWeeklyReport));

            var report = (EWeeklyReport)serializer.Deserialize(HttpContext.Request.InputStream);
            _context.WeeklyReports.Add(report);
            _context.SaveChanges();

            return new EmptyResult();
        }

        public ActionResult MonthlyReport(string xmlData)
        {
            var serializer = new XmlSerializer(typeof(EMonthlyReport));

            var report = (EMonthlyReport)serializer.Deserialize(HttpContext.Request.InputStream);
            _context.MonthlyReports.Add(report);
            _context.SaveChanges();

            return new EmptyResult();
        }
    }
}