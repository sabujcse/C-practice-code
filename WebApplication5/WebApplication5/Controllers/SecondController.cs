using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Models.MyModel;

namespace WebApplication5.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult MyView()
        {
            Employee employee = new Employee();
            employee.FirstName = "Sabuj";
            employee.Lastname = "Sujoy";
            employee.salary = 20000;
            Person person = new Person();
            person.FullName = employee.FirstName + " " + employee.Lastname;
            person.Salary = employee.salary;
            if (person.Salary > 15000)
            {
                person.Salarycolor = "yellow";
            }
            else
            {
                person.Salarycolor = "green";
            }
            person.UserName = "Admin";
            return View("GetView",person);
        }
    }
}