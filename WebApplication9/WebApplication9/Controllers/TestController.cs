using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using WebApplication9.ViewModels;
namespace WebApplication9.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetView()
        {
            Employee employee = new Employee();
            employee.Firstname = "Sabuj";
            employee.LastName = "Sarker";
            employee.Salary = 40000;

            EmployeeViewModel employeeView = new EmployeeViewModel();
            employeeView.EmployeeName = employee.Firstname + " " + employee.LastName;
            employeeView.Salary = employee.Salary.ToString("C");
            if (employee.Salary > 15000)
            {
                employeeView.SalaryColor = "green";
            }
            else
            {
                employeeView.SalaryColor = "green";
            }
            employeeView.UserName = "Admin";
            return View("MyView",employeeView);
        }
    }
}