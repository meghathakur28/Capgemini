using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositiveIntegers_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the n : number of elements");
            int n = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0;i<n;i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) break;
                if (arr[i] < 0) continue;
                sum += arr[i];
            }
            Console.WriteLine("The sum is : "+ sum);
        }
    }
}
