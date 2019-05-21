using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVCApp.Models
{
    public class Customer
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int Age { get; set; }
        public int LoyalityPoin { get; set; }
    }
}