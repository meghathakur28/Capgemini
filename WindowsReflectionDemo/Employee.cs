using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsReflectionDemo
{
    public  class Employee
    {
        public int id {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public void ShowAllEMployees()
        {

        }
        public Employee SearchEmployeeByID(int id)
        {
            Employee employee = new Employee();
            return employee;
        }
    }
}
