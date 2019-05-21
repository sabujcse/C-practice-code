using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AgainBAL.Models;

namespace AgainBAL.DBContextBal
{
    public class DBContextSet:DbContext
    {
       public DbSet<Student> students { get; set; }
    }
}