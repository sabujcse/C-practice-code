using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgainBAL.DBContextBal;
using AgainBAL.Models;
using System.Data.Entity;
namespace AgainBAL.DLL
{
    public class Repository
    {
        DBContextSet contextSet = new DBContextSet();
        bool checkFlag = false;
        public List<Student> GetAll()
        {
            return contextSet.students.ToList();
        }
        public Student GetById( int id)
        {
            Student student = contextSet.students.Where(c => c.Id == id).FirstOrDefault();
            return student;
        }
        public bool Update(Student student)
        {
            contextSet.Entry(student).State = EntityState.Modified;
            if (contextSet.SaveChanges() > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }
        public bool Save( Student student)
        {
            contextSet.students.Add(student);
            if (contextSet.SaveChanges() > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }
    }
}