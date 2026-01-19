using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third Number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            if(num1>num2&&num1>num3)
            {
                Console.WriteLine(num1 + " is the largest number");
            }
            else if(num2>num3&&num2>num1)
            {
                Console.WriteLine(num2 + " is the largest number");
            }
            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine(num3 + " is the largest number");
            }
            else if(num1 == num2&& num1 == num3)
            {
                Console.WriteLine("All numbers are equal");
            }
            else
            {
                Console.WriteLine("Two numbers are equal");
            }
        }
    }
}
