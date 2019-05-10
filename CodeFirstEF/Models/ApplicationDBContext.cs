using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext():base("DefaultConnection")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDBContext, CodeFirstEF.Migrations.Configuration>());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}