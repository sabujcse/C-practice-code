using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace kuvenkat.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Empolyee> Employees { get; set; }
    }
}