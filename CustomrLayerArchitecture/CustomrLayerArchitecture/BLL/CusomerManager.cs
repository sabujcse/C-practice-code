using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomrLayerArchitecture.DLL;
using CustomrLayerArchitecture.Models;

namespace CustomrLayerArchitecture.BLL
{
    public class CusomerManager
    {
        static CustomerRepository repository = new CustomerRepository();
        public bool isSaved(Customer customer)
        {
            bool chk = false;
            if (repository.Saved(customer))
            {
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }
    }
}