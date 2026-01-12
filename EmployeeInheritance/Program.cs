using System;
using EmployeeInheritance;

class Program
{
       static void Main(string[] args)
    {
        Employee emp1 = new FinanceEmployee("Alice", "New York");
        Employee emp2 = new MarketingEmployee("Bob", "Los Angeles");
        Console.WriteLine($"{emp1.GetName()} works in {emp1.GetDepartment()} department at {emp1.GetLocation()}. Status: {emp1.GetStatus()}");
        Console.WriteLine($"{emp2.GetName()} works in {emp2.GetDepartment()} department at {emp2.GetLocation()}. Status: {emp2.GetStatus()}");
        emp1.SwitchStatement();
        emp2.SwitchStatement();
        Console.WriteLine($"After switching status:");
        Console.WriteLine($"{emp1.GetName()} Status: {emp1.GetStatus()}");
        Console.WriteLine($"{emp2.GetName()} Status: {emp2.GetStatus()}");
    }

}