using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritance
{
    public class MarketingEmployee:Employee
    {
        public MarketingEmployee(string name, string location) : base("Marketing", name, location)
        {
        }

        public override string GetDepartment()
        {
            return "Finance";
        }

        public override string GetLocation()
        {
            return location;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetStatus()
        {
            return isOnVacation ? "On Vacation" : "Active";
        }

        public override bool SwitchStatement()
        {
            isOnVacation = !isOnVacation;
            return isOnVacation;
        }
    }
}
