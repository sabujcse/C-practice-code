using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;
using WebApplication11.NewFoldar;

namespace WebApplication11.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Myview()
        {
            Employee employee = new Employee();
            employee.FirstName = "Sabuj";
            employee.LastName = "Sarker";
            employee.Salary = 40000;
            EmployeeDetails details = new EmployeeDetails();
            details.FullName = employee.FirstName + " " + employee.LastName;
            details.Salary = employee.Salary.ToString("C");
            if (employee.Salary > 40000)
            {
                details.SalaryColor = "Green";
            }
            else
            {
                details.SalaryColor = "red";
            }
            details.Username = "Admin";
            return View("ViewMy",details);
        }
    }
}