using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.ViewModels;
using WebApplication4.Models;

namespace WebApplication4.Models.ViewModels
{
    public class EmployeeListViewModel
    {
        public Lazy<EmployeeViewModel><employeeviewmodel> Person{ get; set;}
        public string UserName { get; set; }

     }  
}
