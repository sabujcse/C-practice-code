using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVc.Models
{
    public class CustomerClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Code { get; set; }
        public string Email { get; set; }
    }
}