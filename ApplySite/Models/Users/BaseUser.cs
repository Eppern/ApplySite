using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models.Users
{
    public class BaseUser : ApplicationUser
    {
        public string Forename { get; set; }
        public string Surname { get; set; }

    }
}