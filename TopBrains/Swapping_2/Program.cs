using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_2
{
    public  class Program
    {
        public static void SwapRef(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        public static void SwapOut(int num1, int num2 , out int  num1final, out int num2final)
        {
            num1final = num2;
            num2final = num1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1  = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            SwapRef(ref num1, ref num2);
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);

            int num1final;
            int num2final;

            SwapOut(num1, num2, out num1final, out num2final);

            Console.WriteLine("Number1: " + num1final);
            Console.WriteLine("Number2: " + num2final);

        }
    }
}
