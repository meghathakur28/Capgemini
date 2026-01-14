
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo. SeedProjects();

            List<Employee> a = GetUnassignedEmployees(employees,projects);
            foreach (var i in a)
            {
                Console.WriteLine(i.Id);
        }


        Console.WriteLine("LINQ Scenario Boilerplate Loaded");
        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            var list = from data in employees
                       where data.Salary > 60000
                       select data;
            return list.ToList();
            throw new NotImplementedException();
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            List<string> names = new List<string>();
            names = employees.Select(x => x.Name).ToList();
            return names;
            throw new NotImplementedException();
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            var em = from data in employees
                        where data.Department == "HR"
                        select data;
            return em.Any();

            throw new NotImplementedException();
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {

            var emp = from data in employees
                      group data by data.Department into datagroup
                      select new DepartmentCount
                      {
                          Department = datagroup.Key,
                          Count = datagroup.Count()
                      };
            return emp.ToList();
        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {


            var sal = (from data in employees
                       orderby data.Salary descending
                       select data).First();
            return (Employee)sal;
            throw new NotImplementedException();
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            var emp = from data in employees
                      orderby data.Salary, data.Name
                      select data;
            return emp.ToList();
            throw new NotImplementedException();
        }
        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            var result = from data in employees
                         join data2 in projects
                         on data.Id equals data2.EmployeeId
                         select new EmployeeProject
                         {
                             EmployeeName = data.Name,
                             ProjectName = data2.ProjectName
                         };
            return result.ToList();
            throw new NotImplementedException();
        }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {

            var emp = from data in projects
                      select data.EmployeeId;
            var pro = from data2 in employees
                      where !emp.Contains(data2.Id)
                      select data2;
            return pro.ToList();

            throw new NotImplementedException();
        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            var emp = (from data in employees
                       from data2 in data.Skills
                       select data2).Distinct();

            return emp.ToList();
            throw new NotImplementedException();
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            
            throw new NotImplementedException();
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            var emp = (from data in employees
                       select data).Distinct();

            return emp.ToList();
            
            throw new NotImplementedException();
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
