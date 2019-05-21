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
        public ActionResult GetView()
        {
            Employee em = new Employee();
            em.Firstname = "sabuj";
            em.LastName = "Sarker";
            em.Salary = 20000;
            ViewData["Employee"] = em;
            return View("MyView");
        }
        

    }

}