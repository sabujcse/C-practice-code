using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial2.Views;
using MVCTutorial2.
namespace MVCTutorial2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities mVCTutorialEntities = new MVCTutorialEntities();
            Employee employee = mVCTutorialEntities.Employees.SingleOrDefault( x => x.EmployeeId == 1);
            EmployeeModelView employeeModelView = new EmployeeModelView();
            employeeModelView.EmployeeId = employee.EmployeeId;
            employeeModelView.Name = employee.Name;
            employeeModelView.Address = employee.Address;
            return View(employeeModelView);
        }
    }
}