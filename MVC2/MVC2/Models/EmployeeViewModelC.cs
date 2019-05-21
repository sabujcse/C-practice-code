using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class EmployeeViewModelC
    {
        public int EmployeeId  {get; set;}
        public string Name     {get; set;}
        public string Address  {get; set;}
        public Nullable<int> Departmentid {get; set;}
        public string DepartmentName {get; set;}
        public bool Remember   {get; set; }
        public string SiteName {get; set;}
    }
}