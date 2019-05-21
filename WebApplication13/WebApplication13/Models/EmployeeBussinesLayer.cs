using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication13.DataAccessLayer;

namespace WebApplication13.Models
{
    public class EmployeeBussinesLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesERPDAL = new SalesERPDAL();
            return salesERPDAL.Employees.ToList();
            

        }
    }
}