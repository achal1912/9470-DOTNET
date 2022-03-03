using MvcMultipleTable_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMultipleTable_Demo.ViewModel
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; } //IEnumerable is an interface that defines one method getenumerator.It is a base interface of all non generic collection
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Incentive> Incentives { get; set; }
    }
}