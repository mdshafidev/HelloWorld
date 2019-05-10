using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Dept
    {
        [Key]
        public int DId { get; set; }
        [ConcurrencyCheck]
        public string DName { get; set; }
        public DateTime Date { get; set; }
        public DateTime DNameDescription { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}