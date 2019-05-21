using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult GetView()
        {
            Employee em = new Employee();
            
            em.firstname = "sabuj";
            em.lastname = "sarker";
            em.Salary = 2000;
            em.age = 24;
            //ViewBag.Employee = em;
            
            return View("MyView",em);
        }
    }
}