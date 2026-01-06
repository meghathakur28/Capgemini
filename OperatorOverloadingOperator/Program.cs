using System;
using OperatorOverloadingOperator;
public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 100;
        int num2 = 200;
        int numResult = num1 + num2;
        Console.WriteLine(numResult);
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "Alok";
        emp1.Salary = 10000;

        Employee emp2 = new Employee();
        emp2.EmpID = 102;
        emp2.EmpName = "Riya";
        emp2.Salary = 34000;

        Employee emp3 = new Employee();
        emp3.EmpID = 103;
        emp3.EmpName = "Megha";
        emp3.Salary = 90000;

        // how to do this
        Employee result = emp1 + emp2 +emp3;
        // to do this we need operator overloading

        Console.WriteLine($"Total Sal Paid: {result}");
    }
}
