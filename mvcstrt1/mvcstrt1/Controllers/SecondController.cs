using mvcstrt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcstrt1.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            Department department = db.Departments.SingleOrDefault(x => x.Id == 1);
            DepartmentViewModel departmentView = new DepartmentViewModel();
            departmentView.Id = department.Id;
            departmentView.Name = department.Name;
            departmentView.Code = department.Code;
            return View(departmentView);
        }
    }
}