using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial4.Models;

namespace MVCTutorial4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            MVCTutorialEntities mVCTutorialEntities = new MVCTutorialEntities();
            Employee employee = mVCTutorialEntities.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            EmployeeViewModel em = new EmployeeViewModel();
            em.EmployeeId = employee.EmployeeId;
            em.Name = employee.Name;
            em.DepartmentId = employee.DepartmentId;
            em.Adress = employee.Adress;



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}