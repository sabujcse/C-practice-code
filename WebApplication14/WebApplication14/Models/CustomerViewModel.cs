using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication14.Models;

namespace WebApplication14.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
    }
}