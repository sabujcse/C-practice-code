using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSECONDFINAL.StudentDBContext;
using EFSECONDFINAL.Models;
using EFSECONDFINAL.BLL;

namespace EFSECONDFINAL.Controllers
{
    public class StudentController : Controller
    {
        StduentManager stduentManager = new StduentManager();
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Student student)
        {
            bool st = false;
            if (stduentManager.AddStudent(student))
            {
                st = true; ;
            }
            else
            {
                st = false;
            }
            return View(student);
        }
        public ViewResult Show()
        {
            return View(stduentManager.GetAllStudent());
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Student student = stduentManager.GetById(id);
           return  View(student);
        } 
        [HttpPost]
        public ActionResult Update(Student student)
        {
            Student students = stduentManager.GetById(student.Id);
            if (students != null)
            {
                students.Name = student.Name;
                students.Email = student.Email;
                students.District = student.District;
                students.Age = student.Age;
                stduentManager.Update(students);
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete( int id)
        {
            Student student = stduentManager.GetById(id);
            stduentManager.Delete(student);
            return View();
        }
    }
}