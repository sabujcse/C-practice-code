using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial4.Models;

namespace MVCTutorial4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //MVCTutorialEntities mVCTutorialEntities = new MVCTutorialEntities();
            //Employee employee = mVCTutorialEntities.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            //EmployeeViewModel em = new EmployeeViewModel();
            //em.EmployeeId = employee.EmployeeId;
            //em.Name = employee.Name;
            //em.DepartmentId = employee.DepartmentId;
            //em.Adress = employee.Adress;
            MVCTutorialEntities mVCe = new MVCTutorialEntities();
            List<Employee> employees = mVCe.Employees.ToList();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            List<EmployeeViewModel> viewModels = employees.Select(x => new EmployeeViewModel
            {
                Name = x.Name,
                EmployeeId = x.EmployeeId
               
                //DepartmentId = x.DepartmentId,
                //Adress = x.Adress
            }).ToList();
            return View(viewModels);
        }
        public ActionResult EmployeDetails( int EmployeeId)
        {
            MVCTutorialEntities mVCTutorialEntities = new MVCTutorialEntities();
            Employee em = mVCTutorialEntities.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);
            EmployeeViewModel emplv = new EmployeeViewModel();
            emplv.Adress = em.Adress;
            emplv.DepartmentId = em.DepartmentId;
            return View(emplv);
        }
    }
}