using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public List<Employee><employee> GetEmployees()
    {
        List<Employee> < employee > employees = new List<Employee>< employee > ();
        Employee emp = new Employee();
        emp.FirstName = "johnson";
        emp.LastName = " fernandes";
        emp.Salary = 14000;
        employees.Add(emp);</ employee ></ employee ></ employee >

        emp = new Employee();
        emp.FirstName = "michael";
        emp.LastName = "jackson";
        emp.Salary = 16000;
        employees.Add(emp);

        emp = new Employee();
        emp.FirstName = "robert";
        emp.LastName = " pattinson";
        emp.Salary = 20000;
        employees.Add(emp);

        return employees;
    }
}