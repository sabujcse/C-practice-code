using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication3.Models
{
    public class EmployeeViewClass
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Enter Department Name")]
        public Nullable<int> Departmentid { get; set; }
        public virtual Department Department { get; set; }
        public string DepartmentName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site> Sites { get; set; }
        public string SiteName { get; set; }
        public bool IsDelete { get; internal set; }
    }
}