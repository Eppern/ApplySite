using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models.Users
{
    public class Applicant : BaseUser
    {

        public Applicant() : base()
        {
            TargetCompanies = new List<TargetCompany>();
        }

        public DateTime DOB { get; set; }
        public string Title { get; set; }

        public List<string> Professions { get; set; }

        //navigation ids
        public int AddressId { get; set; }
        public int SaulationId { get; set; }
        public int CVId { get; set; }

        //navigation properties
        public virtual Address Address { get; set; }
        public virtual Salutation Salutation { get; set; }
        public virtual ICollection<TargetCompany> TargetCompanies { get; set; }
        public virtual CV CV { get; set; }
    }
}