using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor_13
{
    public class Program
    {
        public static int GCD(int x, int y)
        {
            if (y == 0) return x;
            return GCD(y, x % y);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int gcd = GCD(num1, num2);

            Console.WriteLine($"The greatest Common Divisor of {num1} and {num2}  is {gcd} ");
        }
    }
}
