using ApplySite.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string ForeName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int AddressId { get; set; }
        public int SalutationId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Salutation Salutation { get; set; }
    }
}