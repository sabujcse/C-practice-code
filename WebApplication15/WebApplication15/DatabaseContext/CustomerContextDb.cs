using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using WebApplication15.Models;

namespace WebApplication15.DatabaseContext
{
    public class CustomerContextDb:DbContext
    {
        public DbSet<Customer> customers { get; set; }

    }
}