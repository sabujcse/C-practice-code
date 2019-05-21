using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationlecture2Lab.Models;
namespace WebApplicationlecture2Lab.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.FirstName = "sabuj";
            employee.LastName = "sarker";
            employee.Salary = 23000;
            ViewBag.Employee = employee;
            return View("MyView",employee);
        }
    }
}