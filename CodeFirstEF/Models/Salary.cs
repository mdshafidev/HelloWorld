using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public int SalarForMonth { get; set; }
        public virtual Employee Employees { get; set; }
    }
}