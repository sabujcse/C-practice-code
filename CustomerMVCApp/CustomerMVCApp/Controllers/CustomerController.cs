using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerMVCApp.BLL;
using CustomerMVCApp.Models;
namespace CustomerMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager();
        // GET: Customer
        //Customer Save Action Start Now
        public string SavaeConfirmation = "";
        public String Add(Customer customer)
        {
            if (customerManager.SaveCustomer(customer)) { SavaeConfirmation = "Successfully Saved........!!"; }
            else { SavaeConfirmation = "Not Saved The Information"; }
            return SavaeConfirmation;
        }
        public ViewResult Show(string name)
        {
            DataTable data = customerManager.ShowCustomer(name);
            return View(data);
        }
        public String Delete(string code)
        {
            if (customerManager.DeleteCustmer(code)) { SavaeConfirmation = "Delete Successfully...........!!"; }
            else { SavaeConfirmation = "Something  Wrong Dear Please Try Again"; }
            return SavaeConfirmation;
        }
        public string Update(Customer customer)
        {
            if (customerManager.UpdateCustomer(customer)) { SavaeConfirmation = "Update Customer Data Successfully.....!!"; }
            else { SavaeConfirmation = "Something Wrong Dear Please Try Again"; }
            return SavaeConfirmation;
        }
        
    }
}