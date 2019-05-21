using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFSECONDFINAL.Models;
using EFSECONDFINAL.DLL;

namespace EFSECONDFINAL.BLL
{
    public class StduentManager
    {
        StudentRepository studentRepository = new StudentRepository();
        public List<Student> GetAllStudent()
        {
            return (studentRepository.GetAllStudent());
        }
        public bool AddStudent(Student student)
         {
            if (studentRepository.AddStu(student))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpadateStudentById(Student student)
        {

        }
        public Student GetById(int id)
        {
            return (studentRepository.getById(id));
        }
        public void Update(Student student)
        {
            if (studentRepository.Upadate(student))
            {

            }
        }
        public void Delete(Student student)
        {
            studentRepository.Delete(student);
        }
    }
}