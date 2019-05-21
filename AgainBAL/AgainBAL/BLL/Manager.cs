using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgainBAL.DLL;
using AgainBAL.Models;
namespace AgainBAL.BLL
{
    public class Manager
    {
        Repository repository = new Repository();
        bool flag = false;
        public List<Student> GetAllStudent()
        {
            return (repository.GetAll());
        }
        public Student GetById( int id)
        {
            Student student = repository.GetById(id);
            return student;
        }
        public bool Update(Student student)
        {
            if (repository.Update(student))
            {
                flag = true;
            }
            return flag;
        }
        public bool Save (Student stdunet)
        {
            if (repository.Save(stdunet))
            {
                flag = true;
            }
            return flag;
        }

    }
}