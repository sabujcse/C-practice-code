using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeMVCCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int PhoneNo { get; set; }
    }
}