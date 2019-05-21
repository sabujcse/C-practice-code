using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kuvenkat.Models;
namespace kuvenkat.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Empolyee empolyee = new Empolyee()
            {
                EmpolyeeId = 1,
                name = "sabuj sarker",
                Gender = "Male",
                City = "Jessor"
            };
            return View("Detail");
        }
    }
}