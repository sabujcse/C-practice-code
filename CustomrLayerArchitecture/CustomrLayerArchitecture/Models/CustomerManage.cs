using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomrLayerArchitecture.Models
{
    public class CustomerManage
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int LoyalityPoint { get; set; }
    }
}