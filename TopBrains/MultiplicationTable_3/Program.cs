using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the n: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number (upto table) : ");
            int upto = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= upto; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }
    }
}
