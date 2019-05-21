using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial3.Models;

namespace MVCTutorial3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities mVC = new MVCTutorialEntities();
            Employee employee = mVC.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            EmploeeView emploeeView = new EmploeeView();
            emploeeView.EmployeeId = employee.EmployeeId;
            emploeeView.Name = employee.Name;
            emploeeView.Address = employee.Address;
            return View(emploeeView);
        }
    }
}