using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFSECONDFINAL.StudentDBContext;
using EFSECONDFINAL.Models;
using System.Data.Entity;
namespace EFSECONDFINAL.DLL
{
    public class StudentRepository
    {
        DBcntext dBcntext = new DBcntext();
        Student st = new Student();
        public List<Student> GetAllStudent()
        {
            return (dBcntext.students.ToList());
        }
        public bool AddStu(Student student)
        {
            dBcntext.students.Add(student);
            if (dBcntext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Student getById(int id)
        {
            Student student = dBcntext.students.Where(c => c.Id == id).FirstOrDefault();
            return student;
        }
        public bool Upadate(Student st)
        {
            dBcntext.Entry(st).State = EntityState.Modified;
            if (dBcntext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(Student student)
        {
            dBcntext.students.Remove(student);
            if (dBcntext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}