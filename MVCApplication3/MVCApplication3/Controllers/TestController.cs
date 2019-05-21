using MVCApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<Department> departments = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(departments, "DepartmentId", "DepartmentName");
            List<EmployeeViewClass> employees = db.Employees.Where(x => x.IsDelete == false).Select(x => new EmployeeViewClass {  Name=x.Name ,  DepartmentName = x.Department.DepartmentName,  Address = x.Address,  EmployeeId = x.EmployeeId }).ToList();
            ViewBag.EmployeeList = employees;
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeViewClass model)
        {
            try
            {
                MVCTutorialEntities db = new MVCTutorialEntities();
                List<Department> departments = db.Departments.ToList();
                ViewBag.DepartmentList = new SelectList(departments, "DepartmentId", "DepartmentName");
                Employee employee = new Employee();
                employee.Address = model.Address;
                employee.Name = model.Name;
                employee.Departmentid = model.Departmentid;
                db.Employees.Add(employee);
                db.SaveChanges();
                int latestId = employee.EmployeeId;
                Site site = new Site();
                site.SiteName = model.SiteName;
                site.EmployeeId = latestId;
                db.Sites.Add(site);
                db.SaveChanges();
              
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(model);
        }
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            return View();
        }
    }
}