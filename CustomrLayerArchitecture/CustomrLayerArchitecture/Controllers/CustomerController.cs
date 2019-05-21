using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomrLayerArchitecture.Models;
using CustomrLayerArchitecture.BLL;
using CustomrLayerArchitecture.DLL;


namespace CustomrLayerArchitecture.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Test
        public static CusomerManager manager = new CusomerManager();
        public String Addcustomer(Customer customer)
        {
            string alt="";
            if (manager.isSaved(customer))
            {
                alt = "Saved";
            }
            else
            {
                alt = "Not Saved";
            }
            return alt;
        }
    }
}