using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorialVideo.Models;
namespace TutorialVideo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MvcTutorialModel = 
            //List<Employee> employees = new List<Employee>();
            //Employee employee = new Employee();
            //employees.Add(new Employee { Id=  1, Name = "Sabuj", Department = "Cse"});
            //employees.Add(new Employee { Id = 2, Name = "Sujoy", Department = "HSC" });
            //employees.Add(new Employee { Id = 3, Name = "Dipok", Department = "Cse" });
            //employees.Add(new Employee { Id = 4, Name = "Dipto", Department = "EEE" });

            //ViewData["EmployList"] = employees;

            //ViewBag.EmployeeNameVB = "Merry";
            //ViewData["EmployeeNameVD"] = "Ashish";
            //TempData["EmployeeNameTD"] = "John";
            ////ViewBag.Keep();
            ////ViewData.Keep();
            //TempData.Keep();
            return View();
        }
        //public ActionResult SecondPage()
        //{
        //    TempData.Keep();
        //    return View();
        //}
    }
}