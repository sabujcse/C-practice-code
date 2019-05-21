using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication14.Models;
using System.Data.Entity;


namespace WebApplication14.DataBaseContext
{
    public class SPEntities:DbContext
    {
        public DbSet<CustomerViewModel> Customers {get; set;}
    }
}