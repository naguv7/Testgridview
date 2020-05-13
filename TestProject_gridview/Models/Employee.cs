using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject_gridview.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmpName { get; set; }

        public string Dept { get; set; }

        public int emp_age { get; set; }

        public bool IsActive { get; set; }
    }
}