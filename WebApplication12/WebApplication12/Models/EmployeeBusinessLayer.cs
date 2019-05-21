using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication12.DataAccessLayer;

namespace WebApplication12.Models
{
    public class EmployeeBusinessLayer
    {
       // public List<Employee> GetEmployees()
        //public List<Employee> GetEmployee()
        //{
            public List<Employee> GetEmployees()
            {
                SalesERPDAL salesDal = new SalesERPDAL();
                return salesDal.Employees.ToList();
            }
        //}
    }
}