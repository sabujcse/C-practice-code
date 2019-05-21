using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowppingStore.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public int ProducerId { get; set; }
        public string Title { get; set; }
        public decimal price { get; set; }
        public Category Category { get; set; }
        public Category producer { get; set; }
    }
}