using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.ViewModels;

namespace WebApplication4.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult MyView()
        {
            Person person = new Person();
            person.FirstName = "Sukesh";
            person.LastName = "Marla";
            person.age = 45;
            person.salary = 20000;
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.EmployeeName = person.FirstName + " " + person.LastName;
            employeeViewModel.Salary = person.salary.ToString("D");
            if (person.salary > 15000)
            {
                employeeViewModel.SalaryColor = "yellow";
            }
            else{
                employeeViewModel.SalaryColor = "green";
            }

           // employeeViewModel.UserName = "Admin";
                return View("SpView", employeeViewModel);
            return View("SpView",person);
        }
    }
}