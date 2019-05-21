using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;
using WebApplication14.DataBaseContext;




namespace WebApplication14.Controllers
{
    public class CustomerController : Controller
    {
        Models.SPEntities db = new Models.SPEntities();
        DataBaseContext.SPEntities Context = new DataBaseContext.SPEntities();
        CustomerViewModel Customer = new CustomerViewModel()
        {
            Id = 1,
            Name="Sabuj Sarker",
            Address ="Jessore",
            Code = "c1"
            
        };
        // GET: Customer
        public string Add()
        { 
         
            Context.Customers.Add(Customer);
            if (Context.SaveChanges() > 0)
            {
                return "Saved";
            }

            return "Not Saved";
        }

       
    }
}