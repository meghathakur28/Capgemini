using System;
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int,double> employees = new Dictionary<int,double>();
        List<int> employeeids = new List<int>() { 1,4,5};

        for(int i=0;i<employeeids.Count;i++)
        {
            Console.WriteLine("Enter the salary for the employee with employee id:"+employeeids[i]);
            employees[employeeids[i]] = double.Parse(Console.ReadLine());
        }

        var salary = employees.Select(x => x.Value).Sum();
        Console.WriteLine("The sum of salary is: " + salary);



    }
}
