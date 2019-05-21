using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQEXAMPLE.Models;

namespace LINQEXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(){ Id = 1, Name= "A", Phone ="0187879", Salary = 12345});
            employees.Add(new Employee() { Id = 1, Name = "B", Phone = "0187879", Salary = 12345 });
            employees.Add(new Employee() { Id = 1, Name = "C", Phone = "0187879", Salary = 5345 });
            employees.Add(new Employee() { Id = 1, Name = "D", Phone = "0187879", Salary = 20345 });
            employees.Add(new Employee() { Id = 1, Name = "E", Phone = "0187879", Salary = 11345 });
            employees.Add(new Employee() { Id = 1, Name = "F", Phone = "0187879", Salary = 345 });
            employees.Add(new Employee() { Id = 1, Name = "G", Phone = "0187879", Salary = 2345 });
            employees.Add(new Employee() { Id = 1, Name = "H", Phone = "0187879", Salary = 5000 });
            employees.Add(new Employee() { Id = 1, Name = "I", Phone = "0187879", Salary = 1234 });
            employees.Add(new Employee() { Id = 1, Name = "J", Phone = "0187879", Salary = 20000 });
            employees.Add(new Employee() { Id = 1, Name = "K", Phone = "0187879", Salary = 13000 });
            employees.Add(new Employee() { Id = 1, Name = "L", Phone = "0187879", Salary = 40000 });
            employees.Add(new Employee() { Id = 1, Name = "M", Phone = "0187879", Salary = 12300 });
            employees.Add(new Employee() { Id = 1, Name = "N", Phone = "0187879", Salary = 190000 });
            //Linq
            var LINQvalue = (from employee in employees
                            where employee.Salary >= 5000 && employee.Salary <= 20000 orderby employee.Salary descending select employee).ToList();
            //Lamda Expression
            var LINQWithLamda = employees.Where(employee => employee.Salary > 5000 && employee.Salary < 20000);
            //foreach(var linq in LINQvalue)
            //{
            //    Console.WriteLine(linq.Name+" "+linq.Salary);
            //}
            foreach (var linq in LINQWithLamda)
            {
                Console.WriteLine(linq.Name + " " + linq.Salary);
            }
            Console.ReadKey();
        }
    }
}
