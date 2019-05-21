using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorlMvc.Models
{
    public class Student
    {
        public int    Id   {get; set;}
        [Required]
        public string Name { get; set;}

        [Required]
        [Display(Name="Reg No *")]

        public string RegNo { get; set;}

        public string Address { get; set;}

        [Required]
        [DisplayName("Subdistrict Name *")]
        public int   SubDistrictId { get; set;}

        public List<SelectListItem> SubdistrictLookUp { get; set; }

    }
}