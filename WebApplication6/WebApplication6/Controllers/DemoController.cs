using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            connectionDBEntities DB = new connectionDBEntities();
            List<Test> t = DB.Tests.ToList();

            return View(t);
        }
    }
}