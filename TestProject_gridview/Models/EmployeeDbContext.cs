using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestProject_gridview.Models
{
    public class EmployeeDbContext:DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; }
    }
}