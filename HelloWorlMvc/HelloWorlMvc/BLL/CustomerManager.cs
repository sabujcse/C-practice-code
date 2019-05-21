using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorlMvc.Models;
using HelloWorlMvc.DLL;

namespace HelloWorlMvc.BLL
{
    public class CustomerManager
    {
        
        CustomerRepository customer = new CustomerRepository();
        public bool flag = false;
        public bool Save(Student student)
        {
            if (customer.SaveData(student))
            {
                flag = true;
            }
            return flag;
        }

        public List<Student> Search(Student student)
        {
            var dataList = customer.Search(student);
            return dataList;
        }

        public Student GetById(int id)
        {
            var student = customer.GetById(id);
            return student;
        }

        public bool Update(Student student)
        {
            var isUpdate = customer.Udatedata(student);
            return isUpdate;
        }
    }
}