﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StactManagment.Models
{
    class StackIn
    {
       public int ID { get; set; }
       public int CompanyID { get; set; }
       public int ItemID { get; set; }
       public decimal StockInQuantity { get; set; }
        public DateTime StockINDate { get; set; }

    }
}
