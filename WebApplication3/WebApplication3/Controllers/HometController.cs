using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HometController : Controller
    {
        // GET: Homet
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetHome()
        {
            return View("MyHome");
        }
    }
}