using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication4.Models;

namespace MVCApplication4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities mvc = new MVCTutorialEntities();
            List<Employee> list = mvc.Employees.ToList();
            ViewBag.EmployeeList = new SelectList(list, "EmployeeId", "DepartmentId");




            //MVCTutorialEntities mVC = new MVCTutorialEntities();
            //List<Employee> employees = mVC.Employees.ToList();
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //List<EmployeeDetails> emd = employees.Select(x => new EmployeeDetails {

            //    Name = x.Name,
            //    EmployeeId = x.EmployeeId
                
            //}).ToList();
            return View(/*emd*/);
        }
        public ActionResult SaveResult(EmployeeDetails model)
        {
            try
            {
                MVCTutorialEntities db = new MVCTutorialEntities();
                Employee empl = new Employee();
                empl.Name = model.Name;
                empl.Adress = model.Adress;
                empl.DepartmentId = model.DepartmentId;

                db.Employees.Add(empl);
                db.SaveChanges();
                //int latestedId = empl.EmployeeId;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            

            return View();
        }
        //public ActionResult Details(int EmployeeId)
        //{
        //    MVCTutorialEntities mvc = new MVCTutorialEntities();
        //    Employee empl = mvc.Employees.SingleOrDefault( x=>x.EmployeeId ==EmployeeId);
        //    EmployeeDetails employeeDetails = new EmployeeDetails();

           
        //    employeeDetails.EmployeeId = empl.EmployeeId;
        //    employeeDetails.DepartmentId = empl.DepartmentId;
        //    employeeDetails.Adress = empl.Adress;
            
        //    return View(employeeDetails);
        //}
    }
}