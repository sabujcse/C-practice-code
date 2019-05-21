using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //MVCTutorialEntities db = new MVCTutorialEntities();
            //Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId==1);
            //EmployeeViewModelC viewModelC = new EmployeeViewModelC();
            //viewModelC.EmployeeId = employee.EmployeeId;
            //viewModelC.Name = employee.Name;
            //viewModelC.Address = employee.Address;
            //viewModelC.Departmentid = employee.Departmentid;
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<Employee> employees = db.Employees.ToList();
           
            List<EmployeeViewModelC> employeeViews = employees.Select(x => new EmployeeViewModelC
            {
                Name = x.Name,
                EmployeeId = x.EmployeeId,
               

            }).ToList();
            return View(employeeViews);
        }

        public ActionResult EmployeeDetails(int EmployeeId)
        {
           
            MVCTutorialEntities db = new MVCTutorialEntities();
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);
            EmployeeViewModelC emplVM = new EmployeeViewModelC();
            emplVM.Name = employee.Name;
            emplVM.Address = employee.Address;
            emplVM.DepartmentName = employee.Department.DepartmentName;
            return View(emplVM);
        }
        public ActionResult Get()
        {
            return View();
        }
        //Tutorial 10
        public ActionResult Tutorial10(EmployeeViewModelC model)
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<Department> departments = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(departments, "DepartmentId", "DepartmentName");
            Employee emp = new Employee();
            emp.Address = model.Address;
            emp.Name = model.Name;
            emp.Departmentid = model.Departmentid;
            db.Employees.Add(emp);
            db.SaveChanges();
            int latestId = emp.EmployeeId;
            Site site = new Site();
            
        
            return View(model);
        }
        //Tutorial 11
        public ActionResult SaveRecodrd(EmployeeViewModelC modelC)
        {
            try
            {
                MVCTutorialEntities db = new MVCTutorialEntities();
                Employee emp = new Employee();
                emp.Name = modelC.Name;
                emp.Address = modelC.Address;
                emp.Departmentid = modelC.Departmentid;

                db.Employees.Add(emp);
                db.SaveChanges();
                int lastEmpId = emp.EmployeeId;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Tutorial10");
        }
        //public ActionResult Index()
        //{
        //    return View(model);
        //}
    }
}