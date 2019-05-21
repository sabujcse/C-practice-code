using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
using WebApplication15.DatabaseContext;

namespace WebApplication15.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerContextDb ContextDb = new CustomerContextDb();
        Customer customer = new Customer()
        {
            Id = 1,
            Name = "Sabuj",
            Code = "c1"
        };
        
       public string Add()
        {
            ContextDb.customers.Add(customer);
            if (ContextDb.SaveChanges() > 0)
            {
                return "Saved";
            }
            else
            {
                return "Not Saved";
            }
        }
    }
}