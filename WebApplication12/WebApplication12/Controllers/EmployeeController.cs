using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;
using WebApplication12.ViewModel;

namespace WebApplication12.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            EmployeeListViewModel employeeList = new EmployeeListViewModel();
            EmployeeBusinessLayer employeeBusiness = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusiness.GetEmployees();
            List<EmployeeViewmodel>  empViewModels = new List<EmployeeViewmodel>();
            foreach(Employee emp in employees)
            {
                EmployeeViewmodel viewmodel = new EmployeeViewmodel();
                viewmodel.FullName = emp.FirstName + " " + emp.LastName;
                viewmodel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 200000)
                {
                    viewmodel.SalaryColor = "green";
                }
                else
                {
                    viewmodel.SalaryColor = "red";
                }
                empViewModels.Add(viewmodel);
            }
            employeeList.Employees = empViewModels;
            return View("Index",employeeList);
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
    }
}