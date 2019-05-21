using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            EmployViewModel employeeMV = new EmployViewModel();

            employeeMV.EmployeeId = employee.EmployeeId;
            employeeMV.Name = employee.Name;
            employeeMV.Address = employee.Address;
 
            return View(employeeMV);
        }
    }
}