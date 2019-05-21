using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDEmo.Models
{
    public class ExampleContext : DbContext
    {
         public DBSet<Example> Examples { get; set; }
    }
}