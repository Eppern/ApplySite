﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models.Users
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string HouseNr { get; set; }
        public string DoorNr { get; set; }
    }
}