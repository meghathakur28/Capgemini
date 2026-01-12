using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritance
{
    public abstract class Employee
    {
        protected string department;
        protected string name;
        protected string location;
        protected Boolean isOnVacation = false;
        public Employee(string department,string name, string location)
        {
            this.department = department;
            this.name = name;
            this.location = location;
        }
        public abstract string GetDepartment();
        public abstract string GetName();
        public abstract string GetLocation();
        public abstract string GetStatus();
        public abstract Boolean SwitchStatement();

    }
}
