using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_ajax_demo.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Facts { get; set; }
    }
}
