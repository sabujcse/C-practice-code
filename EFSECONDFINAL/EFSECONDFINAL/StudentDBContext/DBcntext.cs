using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EFSECONDFINAL.Models;

namespace EFSECONDFINAL.StudentDBContext
{
    public class DBcntext:DbContext
    {
        public DbSet<Student> students { get; set; }
        

       
    }
}