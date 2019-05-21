﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcstrt1.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Departmentid { get; set; }
    }
}