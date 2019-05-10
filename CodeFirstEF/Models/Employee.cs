using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public DateTime DOJ { get; set; }
        public Dept Dept { get; set; }
        public virtual Address Addresses { get; set; }
    }
}