using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication13.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> employeeViews { get; set; }
        public string UserName { get; set; }
    }
}