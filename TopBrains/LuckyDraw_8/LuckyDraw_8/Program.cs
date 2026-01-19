using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw_8
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number2: ");
            int  num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lucky NUmber between " + num1 + " and" + num2);
            int count = 0;
            for (int i = num1; i <= num2; i++)
            {
                int n1 = i;
                int n2 = i * i;

                int sum1 = 0;
                int sum2 = 0;
                while(n1>0)
                {
                    int rem = n1 % 10;
                    sum1 += rem;
                    n1 /= 10;
                }

                while (n2 > 0)
                {
                    int rem = n2 % 10;
                    sum2 += rem;
                    n2 /= 10;
                }

                if(sum1*sum1 == sum2)
                {
                    count++;
                }

            }
            Console.WriteLine(count);

        }
    }
}
