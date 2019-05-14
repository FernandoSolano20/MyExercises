using Paladin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paladin.ViewModels
{
    public class EmploymentSummary
    {
        public EmploymentSummary()
        {
            PrimaryEmployer = new EmploymentVM();
            PreviousEmployer = new EmploymentVM();
        }
        public EmploymentVM PrimaryEmployer { get; set; }
        public EmploymentVM PreviousEmployer { get; set; }
    }
}