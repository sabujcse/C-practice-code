using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Models
{
    class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> students;
        public Department(string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
            students = new List<Student>();
        }
        public List<Student> student()
        {
            return students;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

    }
}
