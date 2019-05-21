using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial4.Models;

namespace MVCTutorial4.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Depart()
        {
            MVCTutorialEntities mV = new MVCTutorialEntities();
            Department department = mV.Departments.SingleOrDefault(y => y.DepartmentId == 1);
            DepartmentViewModel departmentView = new DepartmentViewModel();
            departmentView.DepartmentId = department.DepartmentId;
            departmentView.DepartmentName = department.DepartmentName;
            return View(departmentView);
        }
    }
}