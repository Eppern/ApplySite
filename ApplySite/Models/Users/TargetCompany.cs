using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models.Users
{
    public class TargetCompany
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public int ContactId { get; set; }
        public int AddressId { get; set; }

        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}