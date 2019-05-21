using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationLecture2.Models;

namespace WebApplicationLecture2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.FirstName = "sabuj";
            employee.Lastname = "sarker";
            employee.salary = 2500;

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.EmployeeName = employee.FirstName + " " + employee.Lastname;
            employeeViewModel.Salary = employee.salary.ToString("C");
            if (employee.salary > 100500)
            {
                employeeViewModel.SalaryColor = "green";
            }
            else
            {
                employeeViewModel.SalaryColor = "yellow";
            }
            //employeeViewModel.Username = "Admin";
            
            //ViewData["Employee"] = employee;
            return View( "Myview", employeeViewModel);
        }
        //public ActionResult Index2()
        //{
        //    Employee employee = new Employee();
        //    employee.FirstName = "sabuj";
        //    employee.Lastname = "sarker";
        //    employee.salary = 2500;
        //    ViewData["Employee"] = employee;
        //    return View("View");
        //}
    }
}