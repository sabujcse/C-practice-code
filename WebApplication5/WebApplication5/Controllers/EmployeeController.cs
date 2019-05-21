using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                name = "sabuj sarker",
                Gender = "Male",
                City = "Jessor"
            };
            return View(employee);
            
        }
    }
}