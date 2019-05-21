using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
using WebApplication13.ViewModel;
using WebApplication13.Controllers;

namespace WebApplication13.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyView()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBussinesLayer employeeBussinesLayer = new EmployeeBussinesLayer();
            List<Employee> employees = employeeBussinesLayer.GetEmployees();
            List<EmployeeViewModel> employeeViews = new List<EmployeeViewModel>();
            foreach(Employee employee in employees)
            {
                EmployeeViewModel viewModel = new EmployeeViewModel();
                viewModel.FullName = employee.FirstName + " " + employee.LastName;
                viewModel.Salary = employee.Salary.ToString("C");
                if (employee.Salary > 2000000)
                {
                    viewModel.SalaryColor = "green";
                }
                else
                {
                    viewModel.SalaryColor = "red";
                }
                employeeViews.Add(viewModel);
            }
            employeeListViewModel.employeeViews = employeeViews;
            employeeListViewModel.UserName = "Admin";
            return View("GetView",employeeListViewModel);
        }
    }
}