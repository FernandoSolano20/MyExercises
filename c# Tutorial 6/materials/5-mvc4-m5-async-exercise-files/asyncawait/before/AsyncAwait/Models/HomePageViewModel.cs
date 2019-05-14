using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AsyncAwait.Models
{
    public class HomePageViewModel
    {
        private Stopwatch _watch;

        public HomePageViewModel()
        {
            _watch = Stopwatch.StartNew();
        }

        public string Headline { get; set; }

        public double Temperature { get; set; }

        public long ElapsedTime
        {
            get { return _watch.ElapsedMilliseconds; }
        }
    }
}