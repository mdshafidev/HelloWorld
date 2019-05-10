using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string AddressName { get; set; }
        public int PIN { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}