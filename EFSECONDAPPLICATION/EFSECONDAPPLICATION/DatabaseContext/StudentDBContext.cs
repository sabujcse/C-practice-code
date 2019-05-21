using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EFSECONDAPPLICATION.Models;

namespace EFSECONDAPPLICATION.DatabaseContext
{
    public class StudentDBContext: DbContext
    {
      DbSet<Student> students { get; set; }
    }
}