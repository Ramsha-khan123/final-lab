using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public interface Employee
    {
        int Emp_id { get; set; }
        string Emp_name { get; set; }
        string Emp_type { get; set; }
        int HourWorkInMonth { get; set; }
        int NoofUnitProdct { get; set; }

        void CalculateSalary();
    }
}