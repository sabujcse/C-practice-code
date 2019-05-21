using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerMVc.Models;
using CustomerMVc.DAL;
using System.Data;

namespace CustomerMVc.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRep rep = new CustomerRep();
        // GET: Customer
       
        public string Save(CustomerClass customer)
        {
            rep.IsSaved(customer);
            return "success";
        }
        public ActionResult Show()
        {
            DataTable data = rep.Show();
            return View(data);
        }
    }
}