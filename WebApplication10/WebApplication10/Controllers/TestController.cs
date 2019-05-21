using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
using WebApplication10.ViewModel;
namespace WebApplication10.Controllers
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
            employee.FisrtName = "Sabuj";
            employee.LastName = "Sarker";
            employee.Salary = 400000;
            EmployeeViewModel employeeView = new EmployeeViewModel();
            employeeView.EmployeeName = employee.FisrtName + " " + employee.LastName;
            employeeView.Salary = employee.Salary.ToString("C");
            if (employee.Salary > 2000000)
            {
                employeeView.SalaryColor = "green";
            }
            else
            {
                employeeView.SalaryColor = "red";
            }
            employeeView.UserName = "Admin";
            return View("MyView",employeeView);
        }
    }
}