using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kuvenkat.Models;
namespace kuvenkat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Empolyee empolyee = new Empolyee()
            {
                EmpolyeeId = 1,
                name = "Sabuj Sarker",
                Gender = "Male",
                City = "Jessor"
            };
            return View(empolyee);
        }
      
      
    }
}