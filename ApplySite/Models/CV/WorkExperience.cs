using ApplySite.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models
{
    public class WorkExperience
    {
        public int WorkExperienceId { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Text { get; set; }

        public string ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}