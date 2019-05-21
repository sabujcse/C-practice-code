using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgainBAL.Models;
using AgainBAL.DBContextBal;
using AgainBAL.BLL;
namespace AgainBAL.Controllers
{
    public class StudentController : Controller
    {
        Manager manager = new Manager();
       [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student student)
        {
            manager.Save(student);
            return View(student);
        }
        public ActionResult Show()
        {
            return View(manager.GetAllStudent());
        }
        [HttpGet]
        public ActionResult Update( int id)
        {
            Student student = manager.GetById(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Update(Student student)
        {
            Student students = manager.GetById(student.Id);
            if (students != null)
            {
                students.Name = student.Name;
                students.Address = student.Address;
                students.Email = student.Email;
                students.Age = student.Age;
                manager.Update(students);
               
            }
            return View();
        }

    }
}