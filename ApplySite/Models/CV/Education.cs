using ApplySite.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string SchoolName { get; set; }
        public string Text { get; set; }

        public string ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}