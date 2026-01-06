using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadingOperator
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public static Employee operator +(Employee a, Employee b)
        {
            Employee temp = new Employee();
            temp.Salary  = a.Salary+b.Salary;
            return temp;
        }

    }
}
