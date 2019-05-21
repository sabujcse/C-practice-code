using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CustomerMVCApp.DLL;
using CustomerMVCApp.Models;
namespace CustomerMVCApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository customerRepository = new CustomerRepository();
        bool check = false;
        public bool SaveCustomer(Customer customer)
        {
            if (customerRepository.SaveData(customer)){check = true; }
            return check;
        }
        public DataTable ShowCustomer(string name)
        {
            DataTable data = customerRepository.CustomerData(name);
            return data;
        }
        public bool DeleteCustmer(string code)
        {
            if (customerRepository.DeleteDataByCode(code)) { check = true; }
            return check;
        }
        public bool UpdateCustomer(Customer customer)
        {
            if (customerRepository.UpdateCustomerDataByCode(customer)) { check = true; }
            return check;
        }
    }
}