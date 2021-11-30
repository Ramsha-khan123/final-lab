using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Salaried_Emp : Employee
    {
        public int Emp_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Emp_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Emp_type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HourWorkInMonth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NoofUnitProdct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int salary
        {
            get => default(int);
            set
            {
            }
        }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}