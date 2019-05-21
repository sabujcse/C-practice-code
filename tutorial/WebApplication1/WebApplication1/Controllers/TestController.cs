using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            /*
             * Using ViewData
             * ViewData["Employee"] = emp; 
               return View("MyView");
             */

            /*
             * Using ViewBag
             * ViewData["Employee"] = emp; 
               return View("MyView");
             */
            ViewBag.Employee = emp;
            return View("MyView");

        }
    }
}