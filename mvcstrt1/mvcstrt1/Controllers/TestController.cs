using mvcstrt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcstrt1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            EmployeeViewModel employeevm = new EmployeeViewModel();
            employeevm.EmployeeId = employee.EmployeeId;
            employeevm.Departmentid = employee.Departmentid;
            employeevm.Name = employee.Name;
            employeevm.Address = employee.Address;
            return View(employeevm);
        }
    }
}