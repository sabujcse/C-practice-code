using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial4.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public string Adress { get; set; }
    }
}